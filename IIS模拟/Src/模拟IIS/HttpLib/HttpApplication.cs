﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HttpLib
{
    public class HttpApplication : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var ext = Path.GetExtension(context.HttpRequest.FilePath);
            var type = GetContentTypeByFileExtent(ext);
            var handlers = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IHttpHandler))&&t!=this.GetType())).OrderBy(r => r.Name).ToArray();
            foreach (var handler in handlers)
            {
                var hd = handler as IHttpHandler;
                if (hd != null) hd.ProcessRequest(context);
            }
            if (string .IsNullOrEmpty(ext))//这里我们约定如果没有后缀 则我们是认为调用一个方法
            {
                try
                {
                    var currentAssembly = Assembly.Load("IIS");
                    var instance = currentAssembly.CreateInstance(currentAssembly.GetName().Name+"."+context.HttpRequest.RequestClass+"Controller");
                    context.HttpRespone.ContetType = "text/html"; 
                    if (instance != null)
                        context.HttpRespone.Body = instance.GetType().GetMethod(context.HttpRequest.Method).Invoke(instance, null) as byte[];
                    else
                    {
                        context.HttpRespone.StatusCode = "500 OK";
                       throw new Exception("没有在当前程序集中找到对应的类");
                       
                    }

                    context.HttpRespone.ContetType = "text/html";
                    context.HttpRespone.StatusCode = "200 OK";
                }
                catch (Exception e)
                {
                    context.HttpRespone.ContetType = "text/html";
                    context.HttpRespone.StatusCode = "500 OK";
                    context.HttpRespone.Body = Encoding.Default.GetBytes("<h1 style='Color:red'>"+e.Message+"</h1>");
                  
                }
        
            }
            else
            {
                #region 静态的页面生成

                if (File.Exists(context.HttpRequest.FilePath))
                {
                    context.HttpRespone.Body = File.ReadAllBytes(context.HttpRequest.FilePath);
                    context.HttpRespone.ContetType = type;
                    context.HttpRespone.StatusCode = "200 OK";
                }
                else
                {
                    context.HttpRespone.Body = NotFound();
                    context.HttpRespone.ContetType = type;
                    context.HttpRespone.StatusCode = "404 NotFound";
                }
                #endregion
            }
         
        }

        private string GetContentTypeByFileExtent(string fileExtention)
        {

            string type;
            switch (fileExtention)
            {
                case ".aspx":
                case ".html":
                case ".htm":
                    type = "text/html";
                    break;
                case ".png":
                    type = "image/png";
                    break;
                case ".gif":
                    type = "image/gif";
                    break;
                case ".jpg":
                case ".jpeg":
                    type = "image/jpeg";
                    break;
                case ".css":
                    type = "text/css";
                    break;
                case ".js":
                    type = "application/x-javascript";
                    break;
                default:
                    type = "text/plain; charset=gbk";
                    break;
            }
            return type;

        }
        private byte[] NotFound()
        {
            var strHtml = "<h1>Not Found404</h1>";
            return Encoding.Default.GetBytes(strHtml);
        }
    }
}
