using System;

namespace FactoryMethod.OracleFactory
{
  public  class OracleConnection : BaseConnection
    {
        public override void ConnectToDataBase()
        {
            Console.WriteLine("连接到Oracle");
        }
    }
}
