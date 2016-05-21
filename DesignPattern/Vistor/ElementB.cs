using System;

namespace Vistor
{
    public class ElementB : Element
    {
        public override void Accept(IVistor vistor)
        {
            // 调用访问者visit方法
            vistor.VisitB(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }
}