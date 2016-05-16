using System;

namespace Composite
{
    public class Line:Graphics
    {
        public Line(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画"+this.Name);
        }

       
    }
}