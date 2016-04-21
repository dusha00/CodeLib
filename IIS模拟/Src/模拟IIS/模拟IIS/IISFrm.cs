using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpLib;

namespace IIS
{
    public partial class IISFrm : Form
    {
        public IISFrm()
        {
            InitializeComponent();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            var socket=new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            var endPoint=new IPEndPoint(IPAddress.Parse("127.0.0.1"),50000);
            socket.Bind(endPoint);
            socket.Listen(10);
           
                ThreadPool.QueueUserWorkItem(r =>
                {
                    while (true)
                    {
                        var socketProx = socket.Accept(); //接收数据
                        var bytes = new byte[1024*1024];
                        var len = socketProx.Receive(bytes, 0, bytes.Length, SocketFlags.None);
                        var httpHeader = Encoding.Default.GetString(bytes, 0, len);
                        SetText(httpHeader);

                        if(string.IsNullOrEmpty(httpHeader))return;
                        var context = new HttpContext(httpHeader);
                        var application=new HttpApplication();
                         application.ProcessRequest(context);

                        byte[] responseBytes = context.HttpRespone.Body;
                        socketProx.Send(context.HttpRespone.Header);
                        socketProx.Send(responseBytes);
                        socketProx.Shutdown(SocketShutdown.Both);
                    }
                    //socketProx.Close();
                    //socket.Close();
                });
            
          
 
        }

        private void SetText(string log)
        {
            log += "------------------"+DateTime.Now.ToString("yyyy-MM-dd")+"------------------------------------\n" + log;
            log += "------------------------------------------------------\n\n";
            if (textBox1.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.textBox1.Text += x.ToString(); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                this.textBox1.Invoke(actionDelegate, log);
            }
            else
            {
                this.textBox1.Text += log;
            }
        }
        //private byte[] ResovleHttp(string httpHead)
        //{
        //    string[] requestLines = httpHead.Split(new string[] { "\r\n" }, StringSplitOptions.None);
        //    var requestMethod = requestLines[0].Split(' ')[0];
        //    var requestUrl = requestLines[0].Split(' ')[1]; 
        //    var filePath = Application.StartupPath+Path.Combine(requestUrl);
        //    if (File.Exists(filePath))
        //    {
        //        var fileBytes = File.ReadAllBytes(filePath);
        //        return fileBytes;
        //    }
        //    return NotFound();

        //}


        //private byte[] NotFound()
        //{
        //    var strHtml = "<h1>Not Found404</h1>";
        //    return Encoding.Default.GetBytes(strHtml);
        //}
    }
}
