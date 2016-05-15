namespace FactoryMethod.SqlFactory
{
  public  class SqlFactory:BaseFactory
    {
        public override BaseConnection GetConnection()
        {
             return new SqlConnection();
        }
    }
}
