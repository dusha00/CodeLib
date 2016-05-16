using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
   public class XiNiuTank:Tank
    {
       public override void Show()
       {
            Console.Write(this.Weapon);
       }
    }
}
