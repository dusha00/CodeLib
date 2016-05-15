using System;

namespace FactoryMethod.SqlFactory
{
    class SqlConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到Sql");
        }
    }
}
