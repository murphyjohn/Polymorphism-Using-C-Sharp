using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }

    class Rectangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }
    }

    class Triangle : Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }

        public void TriangleMethod()
        {
            Console.WriteLine("Triangle Method");
        }
    }
}
