using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assicment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.ShapeName = " C bulding ";
            s1.ShapeType = " round ";
            s1.ShowDetails();
            Shape s2 = new Shape("D building ", "Square");
            s2.ShowDetails();
            Rectangle r1 = new Rectangle();
            r1.ShapeName = " Archi bulding ";
            r1.ShapeType = " Square";
            r1.Length = 10.5d;
            r1.Weight = 10.5d;
            r1.ShowDetails();
            Console.WriteLine(r1.IsSquare());
            Console.WriteLine(r1.GetPerimeter());
            Console.WriteLine(r1.GetPerimeter("square centemers"));
            Rectangle r2 = new Rectangle(" Ec bulding ", " rectangle ", 150.9d, 100.0d);
            r2.ShowDetails();
            Console.WriteLine(r2.IsSquare());
            Console.WriteLine(r2.GetPerimeter());
            Console.WriteLine(r2.GetPerimeter("square foots"));
            Circle c = new Circle();
            c.ShapeName = "cricle";
            c.ShapeType = "round ";
            c.Radious = 4.6d;
            c.Color = "Red";
            c.ShowDetails();
            Console.WriteLine("the diamter of the circle is " + c.GetDiameter());
            Console.WriteLine(c.IsLargeCricle());
            Circle c2 = new Circle("Capsole ", "half round ", 19.72, "Gray");
            c2.ShowDetails();
            Console.WriteLine(" the  diametr of the circle is " + c2.GetDiameter());
            Console.WriteLine(c2.IsLargeCricle());
            
           
            Console.ReadKey();
        }
    }
}
