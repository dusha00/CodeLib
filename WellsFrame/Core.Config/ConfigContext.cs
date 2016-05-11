namespace Core.Config
{
    public class ConfigContext
    {
        public IConfigService ConfigService { get; set; }

        public ConfigContext():this(new FileConfigService())
        {

        }

        public ConfigContext(IConfigService configService)
        {
            this.ConfigService = configService;
        }
        public virtual T Get<T>(string index = null) where T : new()
        {
            var result = new T();
            this.VilidateClusteredByIndex(result, index);
            result = this.GetConfigFile<T>(index);

            return result;
        }

        private T GetConfigFile<T>(string index = null) where T :  new()
        {
            var result = new T();

            var fileName = this.GetConfigFileName<T>(index);
            var content = this.ConfigService.GetConfig(fileName);
            if (content == null)
            {
                this.ConfigService.SaveConfig(fileName, string.Empty);
            }
            else if (!string.IsNullOrEmpty(content))
            {
                try
                {
                    result = (T)SerializationHelper.XmlDeserialize(typeof(T), content);
                }
                catch
                {
                    result = new T();
                }
            }

            return result;
        }

        public virtual void VilidateClusteredByIndex<T>(T configFile, string index)
        {
            //if (configFile.ClusteredByIndex && string.IsNullOrEmpty(index))
            //    throw new Exception("调用时没有提供配置文件的分区索引");
        }

        public virtual string GetConfigFileName<T>(string index = null)
        {
            var fileName = typeof(T).Name;
            if (!string.IsNullOrEmpty(index))
                fileName = string.Format("{0}_{1}", fileName, index);
            return fileName;
        }
}

}