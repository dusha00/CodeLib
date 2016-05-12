using AbstractFactory.BaseProduct;
using AbstractFactory.SqlFactory;

namespace AbstractFactory.OracleFactory
{
    class OracleFactory : BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new OracleConnection();
        }

        public override BaseCommond GetCommond()
        {
            return new SqlCommod();
        }

        public override BaseResult GetResult()
        {
            return new OracleResult();
        }
    }
}
