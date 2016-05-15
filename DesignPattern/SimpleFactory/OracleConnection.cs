using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class OracleConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到Oracle");
        }
    }
}
