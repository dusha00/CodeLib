using System.Text.RegularExpressions;
using GMS.Core.Cache;

namespace Core.Cache
{
    public class CacheHelper
    {
        public static object Get(string key)
        {
            var cacheConfig = CacheConfigContext.GetCurrentWrapCacheConfigItem(key);
            return cacheConfig.CacheProvider.Get(key);
        }

        public static void Set(string key, object value)
        {
            var cacheConfig = CacheConfigContext.GetCurrentWrapCacheConfigItem(key);

            cacheConfig.CacheProvider.Set(key, value, cacheConfig.CacheConfigItem.Minitus, cacheConfig.CacheConfigItem.IsAbsoluteExpiration, null);
        }
        public static void Clear(string keyRegex = ".*", string moduleRegex = ".*")
        {
            if (!Regex.IsMatch(CacheConfigContext.ModuleName, moduleRegex, RegexOptions.IgnoreCase))
                return;

            foreach (var cacheProviders in CacheConfigContext.CacheProviders.Values)
                cacheProviders.Clear(keyRegex);
        }

    }
}