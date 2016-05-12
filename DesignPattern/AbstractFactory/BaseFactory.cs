using AbstractFactory.BaseProduct;
 

namespace AbstractFactory
{
    public abstract class BaseFactory
    {
        public abstract BaseConnection GetConnection();
        public abstract BaseCommond GetCommond();
        public abstract BaseResult GetResult();
    }
}
