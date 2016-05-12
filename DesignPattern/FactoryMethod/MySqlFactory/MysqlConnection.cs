using System;

namespace FactoryMethod.MySqlFactory
{
   public class MysqlConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到mysql");
        }
    }
}
