namespace Config
{
    public interface IConfigService
    {
        string GetConfig(string key);
        void SaveConfig(string key);

        string GetConfigInfo();


    }
}