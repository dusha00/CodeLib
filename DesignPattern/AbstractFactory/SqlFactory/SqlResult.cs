using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.SqlFactory
{
    class SqlResult:BaseResult
    {
        public override void GetBaseResult()
        {
            Console.WriteLine("执行sqlCommond");
        }
    }
}
