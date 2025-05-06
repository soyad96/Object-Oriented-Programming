using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assicment3
{
     public class Shape
    {
        protected string shapeName;
        protected string shapeType;
        protected  static int totalShape = 0;
        public string ShapeName
        {
            get { return this.shapeName; }
            set { this.shapeName = value; }

        }
        public string ShapeType
        {
            get { return this.shapeType; }
            set { this.shapeType = value; }
        }
        public Shape()
        {
            totalShape++;
        }
        public   Shape(string shapeName,string shapeType)
        {
            this.shapeName = ShapeName;
            this.shapeType = shapeType;
            totalShape++;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine(" the shape details ");
            Console.WriteLine(" the shape name is " + this.shapeName);
            Console.WriteLine(" the shape type is " + this.shapeType);
            Console.WriteLine(" the totol number os shpe is " + Shape.totalShape);
        }
    }
}
