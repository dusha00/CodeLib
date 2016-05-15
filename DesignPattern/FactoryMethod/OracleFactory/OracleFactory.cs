using FactoryMethod.SqlFactory;

namespace FactoryMethod.OracleFactory
{
  public  class OracleFactory : BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new OracleConnection();
        }
    }
}
