using System;
using System.IO;

namespace Core.Config
{
    public class FileConfigService:IConfigService
    {
        private readonly string _configFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");

        public string GetConfig(string fileName)
        {
            if (!Directory.Exists(_configFolder))
                Directory.CreateDirectory(_configFolder);

            var configPath = GetFilePath(fileName);
            if (!File.Exists(configPath))
                return null;
            else
                return File.ReadAllText(configPath);
        }

        public void SaveConfig(string fileName, string content)
        {
            var configPath = GetFilePath(fileName);
            File.WriteAllText(configPath, content);
        }

        public string GetFilePath(string fileName)
        {
            var configPath = string.Format(@"{0}\{1}.xml", _configFolder, fileName);
            return configPath;
        }
    }
}