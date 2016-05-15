using System;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.OracleFactory
{
    class OracleConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到Oracle");
        }
    }
}
