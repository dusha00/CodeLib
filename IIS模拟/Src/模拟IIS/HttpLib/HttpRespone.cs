using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpLib
{
  public class HttpRespone
    {
      public string StatusCode  { get; set; }
      public string ContetType { get; set; }
      public byte[] Body { get; set; }

      public byte[] Header
      {
          get { return GetHeader(); } 
         
      }

      public byte[] GetHeader()//这里对数据不作太多的处理
      {
          var sb = new StringBuilder();
          sb.AppendLine("HTTP/1.1 {0}");
          sb.AppendLine("Date:" + DateTime.Now);
          sb.AppendLine("Content-Type:" + "{1}");
          sb.AppendLine("Content-Length:" + "{2}");
          sb.AppendLine();//很重要
          var header = string.Format(sb.ToString(), StatusCode, ContetType, Body.Length);
          return Encoding.Default.GetBytes(header);
      }
   
    }
}
