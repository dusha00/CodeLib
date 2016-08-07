using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace Module.Lib
{
    public abstract class UtilityHandler:IHttpHandler,IRouteHandler
    {
        public   void ProcessRequest(HttpContext context)
        {
            var res = context.Response;
            var req = context.Request;

            res.Clear();
            res.ContentEncoding = Encoding.Default;

            if (false)//权限的验证
            {

                res.Write("<h1>无权限查看！</h1>");
            }
            else
            {
                ProcessRequest(req, res);
            }

            res.Flush();
            res.End();
            res.Close();
        }

        public abstract void ProcessRequest(HttpRequest req, HttpResponse res);
        public bool IsReusable { get; }
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return this;
        }

        public const string OK = "ok";
        public const string ERROR = "error";
        protected object[] GetParas(ParameterInfo[] args, HttpRequest request)
        {
            return
                args.Where(r => r.Name != "method")
                    .Select(
                        x =>
                        {
                            if (request[x.Name] != null)
                            {
                                return Convert.ChangeType(request[x.Name], x.ParameterType); ;
                            }
                            if (request.Cookies[x.Name] != null)
                            {
                                return Convert.ChangeType(request.Cookies[x.Name], x.ParameterType); ;
                            }
                            if (request.QueryString[x.Name] != null)
                            {
                                return Convert.ChangeType(request.QueryString[x.Name], x.ParameterType); ;
                            }
                            if (request.Form[x.Name] != null)
                            {
                                return Convert.ChangeType(request.Form[x.Name], x.ParameterType); ;
                            }

                            return null;
                        })
                    .ToArray();
        }

    }

    public class LogHandler : UtilityHandler
    {
        public override void ProcessRequest(HttpRequest req, HttpResponse res)
        {
             
        }
    }

    public class CacheHandler : UtilityHandler
    {
        public override void ProcessRequest(HttpRequest req, HttpResponse res)
        { 

        }
    }

    public class ConfigHandler : UtilityHandler
    {
        public override void ProcessRequest(HttpRequest req, HttpResponse res)
        { 

        }
    }
}