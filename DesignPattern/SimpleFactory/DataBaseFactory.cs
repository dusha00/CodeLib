using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class DataBaseFactory
    {
        public BaseConnection GetConnection(string type)
        {
            switch (type)
            {
                case "sql": return new SqlConnection(); break;
                case "oracle": return new OracleConnection(); break;
                case "mysql": return new MysqlConnection(); break;
                default: return new SqlConnection();
            }
        }

    }
}
