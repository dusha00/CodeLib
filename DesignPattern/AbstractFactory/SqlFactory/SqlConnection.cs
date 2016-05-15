using System;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.SqlFactory
{
    class SqlConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到Sql");
        }
    }
}
