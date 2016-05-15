using FactoryMethod.SqlFactory;

namespace FactoryMethod.MySqlFactory
{
  public  class MysqlFactory : BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new SqlConnection();
        }
    }
}
