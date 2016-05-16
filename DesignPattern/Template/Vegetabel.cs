using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Vegetabel
    {

        public void CookVegetable()
        {
            Console.WriteLine("做饭");
            
        }

        public void PourOil()
        {
            Console.WriteLine("倒油");
        }

        public void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }

        // 油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定
        public abstract void PourVegetable();

        // 开始翻炒蔬菜
        public void stir_fry()
        {
            Console.WriteLine("翻炒");
        }

    }
}
