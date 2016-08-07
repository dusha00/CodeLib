using System;
using System.IO;

namespace Config
{
    public class FileConfigService : IConfigService
    {

        private readonly string _configFoler = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");
        public string GetConfig(string key)
        {
            if (Directory.Exists(_configFoler))
            {
                Directory.CreateDirectory(_configFoler);
            }
            var configPath = GetConfigInfo();
            if (!File.Exists(configPath))
                return null;
            else
            {
                return File.ReadAllText(configPath);
            }
        }

        public string GetConfigInfo()
        {
            throw new NotImplementedException();
        }

        public void SaveConfig(string key)
        {
           
        }
    }
}