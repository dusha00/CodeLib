using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
   public abstract class Command
   {
       protected Receiver Receiver;

       public Command(Receiver receiver)
       {
           this.Receiver = receiver;
       }
       public abstract void Action();
   }
}
