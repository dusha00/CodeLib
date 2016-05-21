using System;

namespace Vistor
{
    public class ElementA:Element
    {
        public override void Accept(IVistor vistor)
        {
            // 调用访问者visit方法
            vistor.VisitA(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }
}