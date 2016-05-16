using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   public class Circle:Graphics
    {
       public Circle(string name) : base(name)
       {
       }

       public override void Draw()
       {
           Console.WriteLine("画"+Name);
       }
 
    }
}
