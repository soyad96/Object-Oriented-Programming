using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assicment3
{
    public  class Rectangle:Shape
    {
        private double length;
        private double weight;
        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Rectangle():base()
        {

        }
        public Rectangle(string shapeName,string shapeType,double length,double weight) : base(shapeName, shapeType)
        {

            this.length = length;
            this.weight = weight;

        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the length is " + this.length);
            Console.WriteLine(" the weight is " + this.weight);
        }
        
        public bool IsSquare()
        {
            if (weight == length)
            {
                return true;
            }
            else return false;
        }
        public double GetPerimeter()
        {
            double p = 2 * (length + weight);
            return p;
        }
        public string  GetPerimeter( string p)
        {
            double n = 2 * (length + weight);
            return $"Perimeter: {n} {p}";
        }
        
    }
}
