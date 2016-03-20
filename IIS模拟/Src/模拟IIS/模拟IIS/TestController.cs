using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS
{
    class TestController
    {
        public byte[] GetHtml()
        {
            var str = "<h1>Hello .Net</h1>";
            return Encoding.Default.GetBytes(str);
        }
    }
}
