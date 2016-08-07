namespace Config.Model
{
    public class ConfigModel:ConfigBase
    {
        //配置的名称
        public string Name { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
         
    }
}