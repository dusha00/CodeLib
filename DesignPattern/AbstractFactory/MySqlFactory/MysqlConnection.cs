using System;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.MySqlFactory
{
    class MysqlConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到mysql");
        }
    }
}
