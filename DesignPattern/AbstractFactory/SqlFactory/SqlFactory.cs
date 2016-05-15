using AbstractFactory.BaseProduct;

namespace AbstractFactory.SqlFactory
{
  public  class SqlFactory:BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new SqlConnection();
        }

      public override BaseCommond GetCommond()
      {
           return new SqlCommod();
      }

      public override BaseResult GetResult()
      {
          return  new SqlResult();
      }
    }
}
