using AbstractFactory.BaseProduct;
using AbstractFactory.OracleFactory;
using AbstractFactory.SqlFactory;

namespace AbstractFactory.MySqlFactory
{
   public class MysqlFactory : BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new MysqlConnection();
        }

        public override BaseCommond GetCommond()
        {
            return new MysqlCommod();
        }

        public override BaseResult GetResult()
        {
             return new MysqlResult();
        }
    }
}
