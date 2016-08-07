using System.Web;

namespace Module.Lib
{
    public class LogModule:IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, System.EventArgs e)
        {
            var context = HttpContext.Current;
            context.Response.Write("<h1>hello</h1>");
            context.Response.Flush();
            context.Response.End();
            context.Response.Close();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}