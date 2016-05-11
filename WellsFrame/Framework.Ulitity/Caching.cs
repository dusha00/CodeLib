using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace Framework.Ulitity
{
    public class Caching
    {
        public static object Get(string key)
        {
            var value = HttpRuntime.Cache[key];
            return value;
        }

        public static void Remove(string key)
        {
            if (HttpRuntime.Cache[key] != null)
            {
                HttpRuntime.Cache.Remove(key);
            }
        }
        public static void Set(string key, object value)
        {
            Set(key,value,null);
        }

        public static void Set(string key, object value, CacheDependency cacheDependency)
        {
            HttpRuntime.Cache.Insert(key, value, cacheDependency, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(20));
        }

        public static void Set(string key, object value, int minus)
        {
            HttpRuntime.Cache.Insert(key,value,null,Cache.NoAbsoluteExpiration,TimeSpan.FromMinutes(20));
        }

        public static void Set(string name, object value, int minutes, bool isAbsoluteExpiration, CacheItemRemovedCallback onRemoveCallback)
        {
            if (isAbsoluteExpiration)
                HttpRuntime.Cache.Insert(name, value, null, DateTime.Now.AddMinutes(minutes), Cache.NoSlidingExpiration, CacheItemPriority.Normal, onRemoveCallback);
            else
                HttpRuntime.Cache.Insert(name, value, null, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(minutes), CacheItemPriority.Normal, onRemoveCallback);
        }


    }
}
