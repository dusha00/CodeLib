using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Prototype
    {
        private string id;

        // Constructor 
        public Prototype(string id)
        {
            this.id = id;
        }

        // Property 
        public string Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }
}
