using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public class Car
    {
       private readonly List<string> _partList=new List<string>();

       public void Add(string part)
       {
           _partList.Add(part);
       }

       public void Show()
       { 
           foreach (var lt in _partList)
           {
               Console.WriteLine(lt);
           }
       }
    }
}
