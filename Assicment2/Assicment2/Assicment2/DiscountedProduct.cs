using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assicment2
{
   public  class DiscountedProduct:Product
    {
        private double discountedPercent;
        private string category;
        public double DiscountedPercent
        {
            get { return this.discountedPercent; }
            set { this.discountedPercent = value; }
        }
        public string  Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
        public DiscountedProduct():base()
        {

        }
        public DiscountedProduct(int productId, string name, double price ,double discountedPercent,string category):base( productId, name, price)
        {
            this.discountedPercent = discountedPercent;
            this.category = category;
        }
        public  override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the discounted price is " + this.discountedPrice);
            Console.WriteLine(" the product category is " + this.category);
        }
        public  double GetFinalPrice()
        {
            double discount = (this.price * this.discountPercent) / 100;
            double actualprice = (this.price - discount);
            double vat = (actualprice * vaTRate) / 100;
            double finalprice(actualprice+vat);
            return finalprice();
            
        }
        public bool HasSeasonalOffer(string category)
        {
            if (this.category =="Festible" ||  this.category == "Winter ")
            {
                return true;
            }
            else
            {
                return  false;
            }
        }

    }
}
