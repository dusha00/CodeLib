using System;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.OracleFactory
{
    class OracleResult : BaseResult
    {
        public override void GetBaseResult()
        {
            Console.WriteLine("执行OracleCommond");
        }
    }
}
