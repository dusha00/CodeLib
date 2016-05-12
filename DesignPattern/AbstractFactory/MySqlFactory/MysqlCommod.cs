using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BaseProduct;

namespace AbstractFactory.SqlFactory
{
    class MysqlCommod : BaseCommond
    {
        public override void GetBaseCommond()
        {
            Console.WriteLine("执行MysqlCommond");
        }
    }
}
