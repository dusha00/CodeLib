using System;

namespace Core.Cache
{
    public interface ICacheProvider
    {
    
 
        object Get(string key);
        void Set(string key, object value, int mimutes, bool isAbsoluteExpiration, Action<string, object, string> onRemove);
        void Remove(string key);
        void Clear(string regex);
    }
}
