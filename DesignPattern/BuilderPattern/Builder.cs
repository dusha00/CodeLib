using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Builder
    {
        public abstract void BuilderSeat();
        public abstract void BuilderWheel();
        public abstract Car GetCar();
    }
}
