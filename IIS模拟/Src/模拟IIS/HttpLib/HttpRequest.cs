﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpLib
{
    public class HttpRequest
    {
        public HttpRequest(string request)
        {
            string[] requestLines = request.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            this.RequestMethod = requestLines[0].Split(' ')[0];
              RequestUrl = requestLines[0].Split(' ')[1];
           
              this.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + RequestUrl);
            var ext = Path.GetExtension(FilePath);
            if (string.IsNullOrEmpty(ext))
            {
                var methodArr = this.RequestUrl.Split('/');
                if(methodArr.Length>1)
                    this.RequestClass = this.RequestUrl.Split('/')[1];
                if (methodArr.Length > 2)
                this.Method = this.RequestUrl.Split('/')[2];
            }
          
        }

        public string RequestUrl { get; set; }
        public string FilePath { get; set; }

        public string RequestMethod { get; set; }
        public string  Method { get; set; }

        private string _requestClass;
        public string RequestClass
        {
            get { return _requestClass + "Controller"; } 
            set { _requestClass = value; }
        }

        public string ContentType { get; set; }

 

    }
}
