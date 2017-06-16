using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Polygon> polygons = new List<Polygon>();
            //polygons.Add(new Polygon());
            //polygons.Add(new Rectangle());
            //polygons.Add(new Triangle());

            //foreach (Polygon p in polygons)
            //{
            //    p.Draw();
            //}

            Triangle t = new Triangle();
            t.Draw();
            Rectangle r = new Rectangle();
            r.Draw();

            Console.WriteLine("\n\n\n");
            Polygon p = t;
            p.Draw();
            Polygon p2 = r;
            p2.Draw();

            //Testing that Methods must be declared in the class of the reference type first. like in Java
            //Polygon testTriangle = new Triangle();
            //testTriangle.TriangleMethod();
        }
    }
}
