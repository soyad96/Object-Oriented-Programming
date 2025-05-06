using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assicment2
{
   public  class Product
    {
        protected  int productId;
        protected string name;
        protected double price;
        protected  static double vaTRate = 0.1d;
        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price= value; }
        }
        public  static double VatRate
        {
            get { return vaTRate; }
            set { vaTRate = value; }
        }
        public Product()
        {

        }
        public Product(int productId,string name,double price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;

        }
        public virtual  void ShowDetails()
        {
            Console.WriteLine(" the product id is " + this.productId);
            Console.WriteLine(" the product name is " + this.name);
            Console.WriteLine(" the product price is  " + this.price);
        }


    }
}
