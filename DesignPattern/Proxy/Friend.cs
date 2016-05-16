using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public class Friend:Person
   {
       private RealBuyPerson _realSubject;

       public override void BuyProduct()
        {
           if (_realSubject == null)
           {
               _realSubject=new RealBuyPerson();
           }
           this.PreButProduct();
          _realSubject.BuyProduct();
           this.PostBuyProduct();
           
        }

       public void PreButProduct()
       {
           Console.WriteLine("好的，我已经准备好了");
       }

       public void PostBuyProduct()
       {
           Console.WriteLine("我已经做完了");
       }
    }
}
