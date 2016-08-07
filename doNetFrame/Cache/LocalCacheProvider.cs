using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cache
{
    public class LocalCacheProvider : ICacheProvider
    {
        public   List<string> KeyList;

         public LocalCacheProvider()
        {
            KeyList = new List<string>();
        }
        public void Clear(string keyRegex)
        {
            var matchList = KeyList.Where(r => Regex.IsMatch(r, keyRegex, RegexOptions.IgnoreCase));
            foreach (var m in matchList)
            {
                KeyList.Remove(m);
                Caching.Remove(m);
            }


        }

        public void ClearAll()
        {

            foreach (var key in KeyList)
            {
                Caching.Remove(key);
            }
            KeyList.Clear();


        }

        public object Get(string key)
        {
            return Caching.Get(key);
        }
 
        public void Remove(string key)
        {
            KeyList.Remove(key);
            Caching.Remove(key);
        }

        public void Set(string key, object value)
        {
            Set(key, value, 20);
        }

        public void Set(string key, object value, int min)
        {
            Set(key, value, min, false);
        }

        public void Set(string key, object value, int min, bool isAbsoluteExpiration)
        {
            Set(key, value, min, isAbsoluteExpiration, null);
        }

        public void Set(string key, object value, int min, bool isAbsoluteExpiration, Action<string, object, string> onRemove)
        {
            KeyList.Add(key);
            Caching.Set(key, value, min, isAbsoluteExpiration, null, (k, v, reason) =>
                {
                    onRemove?.Invoke(k, v, reason.ToString());
                });
        }
    }
}