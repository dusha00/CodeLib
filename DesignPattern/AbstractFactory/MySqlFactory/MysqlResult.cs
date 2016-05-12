using System;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.OracleFactory
{
    class MysqlResult : BaseResult
    {
        public override void GetBaseResult()
        {
            Console.WriteLine("执行MysqlCommond");
        }
    }
}
