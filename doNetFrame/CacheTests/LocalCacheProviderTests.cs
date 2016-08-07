using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Tests
{
    [TestClass()]
    public class LocalCacheProviderTests
    {
        [TestMethod()]
        public void SetTest()
        {
            var cache=new LocalCacheProvider();
            cache.Set("Name","fuwei");
            cache.Set("Name1","fuwei");
            cache.Set("Name2","fuwei");
            var name= cache.Get("Name");
            var keys = cache.KeyList;
            cache.Remove("Name");
            cache.Remove("Name");
            cache.ClearAll();
        }
    }
}