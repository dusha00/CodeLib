using System;
using System.Web;
using System.Web.Caching;

namespace Cache
{
    /// <summary>
    /// 本地缓存帮助类
    /// </summary>
    public class Caching
    {
        public static object Get(string key)
        {
            return HttpRuntime.Cache.Get(key);
        }

        public static void Set(string key, object value,int minutes,bool isAbsolutionExpires, CacheDependency dependencies, CacheItemRemovedCallback onRemoveCallback)
        {
            if (isAbsolutionExpires)
            {
                HttpRuntime.Cache.Insert(key,value,dependencies,DateTime.Now.AddMinutes(minutes),System.Web.Caching.Cache.NoSlidingExpiration,CacheItemPriority.Default,onRemoveCallback);
            }
            else
            {
                HttpRuntime.Cache.Insert(key, value, dependencies,System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(minutes), CacheItemPriority.Default, onRemoveCallback);
            }
        }

       

        public static void Remove(string key)
        {
            if (HttpRuntime.Cache[key] != null)
                HttpRuntime.Cache.Remove(key);
        }

      
    }
}
