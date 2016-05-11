using System;
using System.Text.RegularExpressions;
using System.Web;
using Framework.Ulitity;

namespace Core.Cache
{
    public class LocalCacheProvider : ICacheProvider
    {
        public object Get(string key)
        {
            return Caching.Get(key);
        }

        public void Set(string key, object value, int mimutes, bool isAbsoluteExpiration, Action<string, object, string> onRemove)
        {
            Caching.Set(key,value,mimutes,isAbsoluteExpiration,((s, o, reason) =>
            {
                if (onRemove != null)
                {
                    onRemove(s, o, reason.ToString());
                }
             
            }));
        }

        public void Remove(string key)
        {
            Caching.Remove(key);
        }

        public void Clear(string regex)
        {
            //List<string> keys = new List<string>();
            var enumerator = HttpRuntime.Cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var key = enumerator.Key.ToString();
                if (Regex.IsMatch(key, regex, RegexOptions.IgnoreCase))
                    Remove(key);
            }
 
        }
    }
}
