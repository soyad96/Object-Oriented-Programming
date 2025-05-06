using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assicment3
{
   public  class Circle:Shape
    {
        private double radious;
        private string color;
        public double Radious
        {
            get { return this.radious; }
            set { this.radious = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Circle() : base()
        {

        }
        public Circle(string shapeName,string shapeType,double radious,string color) : base(shapeName, shapeType)
        {
            this.radious = radious;
            this.color = color;
        }
        public  override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the radious is " + this.radious);
            Console.WriteLine(" the color of the circle is " + this.color);
        }
        public double GetDiameter()
        {
            return 2 *  this.radious;
        }
        public bool IsLargeCricle()
        {
            if (this.radious > 10) return true;
            else return false;
        }
          
    }
}
