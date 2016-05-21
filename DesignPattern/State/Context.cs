using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {

        private State state;

        public State State
        {
            set { state = value; }
        }

        private void Request()
        {
            state.Handler(this);
        }
    }
}
