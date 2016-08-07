using System;
using System.Security.Cryptography.X509Certificates;

namespace Cache
{
    public interface ICacheProvider
    {
        object Get (string key);
       

        void Set (string key, object value, int min, bool isAbsoluteExpiration, Action<string, object, string> onRemove);
        void Set(string key, object value, int min, bool isAbsoluteExpiration);
        void Set (string key, object value, int min);
  
        void Set (string key, object value);
      
        void Remove(string key);

        void Clear(string keyRegex);

        void ClearAll();
    }
}