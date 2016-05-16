using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ComplexGraphics : Graphics
    {
        private readonly List<Graphics> graphicses=new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {
        }

        public override void Draw()
        {
            foreach (Graphics g in graphicses)
            {
                g.Draw();
            }
        }

        public   void Add(Graphics g)
        {
           graphicses.Add(g);
        }

        public   void Remove(Graphics g)
        {
           graphicses.Remove(g);
        }
    }
}
