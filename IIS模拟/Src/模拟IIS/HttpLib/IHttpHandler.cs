using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpLib
{
    interface IHttpHandler
    {
         void ProcessRequest(HttpContext context);
    }

 
}
