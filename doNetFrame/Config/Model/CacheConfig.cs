using System.Runtime.InteropServices.ComTypes;
using Microsoft.SqlServer.Server;

namespace Config.Model
{
    public class CacheConfigItemModel : ConfigBase
    {

        public string ProviderName { get; set; }

        public string Minitus { get; set; }

        public string KeyRegex { get; set; }

        public string Priority { get; set; }

        public bool IsAbsoluteExpiratio { get; set; }
        public string Desc { get; set; }
        public string ModuleRegex { get; set; }



    }
    public class CacheProviderItemModel : ConfigBase
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }



    }
}