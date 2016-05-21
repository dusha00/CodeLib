using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class MediatorPater:AbstractMediator
    {
        public MediatorPater(AbstractCardPartner a, AbstractCardPartner b) : base(a, b)
        {
        }

        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }

        public override void BWin(int count)
        {
            B.MoneyCount += count;
            A.MoneyCount -= count;
        }
    }
}
