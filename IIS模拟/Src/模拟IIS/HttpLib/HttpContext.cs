using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpLib
{
    public class HttpContext
    {

        public HttpContext(string httpHeader)
        {
            this.HttpRespone = new HttpRespone();
            this.HttpRequest = new HttpRequest(httpHeader);
        }

        public HttpRequest HttpRequest { get; set; }
        public HttpRespone HttpRespone { get; set; }

    
    }
}
