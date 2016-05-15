using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public class BaoMa:Builder
    {
        readonly Car _car = new Car();
        public override void BuilderSeat()
        {
            _car.Add("baoma Seat");
        }

        public override void BuilderWheel()
        {
            _car.Add("baoma Wheel");
        }

        public override Car GetCar()
        {
            return _car;
        }
    }
}
