using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ParterA:AbstractCardPartner
    {
        public override void ChangeCount(int Count, AbstractMediator mediator)
        {
             mediator.AWin(Count);
        }
    }
}
