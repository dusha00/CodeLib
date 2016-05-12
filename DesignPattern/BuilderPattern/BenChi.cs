using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public class BenChi:Builder
    {
       readonly Car _car=new Car();
        public override void BuilderSeat()
        {
            _car.Add("beichi Seat");
        }

        public override void BuilderWheel()
        {
            _car.Add("beichi Wheel");
        }

        public override Car GetComputer()
        {
            return _car;
        }
    }
}
