namespace Vistor
{
    public class VistorA : IVistor
    {
        // visit方法而是再去调用元素的Accept方法
        public void VisitA(ElementA a)
        {
            a.Print();
        }
        public void VisitB(ElementB b)
        {
            b.Print();
        }
    }
}