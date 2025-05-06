using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assicment2
{
    public  class PremiumProduct:Product
    {
        private int warrentyYears;
        private string countryOfOrigin;
        public int WarrentyYears
        {
            get { return this.warrentyYears; }
            set { this.warrentyYears = value; }
        }
        public string CountryOfOrigin
        {
            get { return this.countryOfOrigin; }
            set { this.countryOfOrigin = value; }
        }
        public PremiumProduct():base()
        {

        }
        public PremiumProduct(int productId, string name, double price,int warrentyYears,string countryOfOrigin): base(productId, name, price)
        {
            this.warrentyYears = warrentyYears;
            this.countryOfOrigin = countryOfOrigin;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(" the product has " + this.warrentyYears);
            Console.WriteLine(" the product has country origin of " + this.countryOfOrigin);
        }
        public bool IsEligibleForVIPReturn()
        {
            if (warrentyYears >= 2)
            {
                return true;
            }
            else return false;
        }
        public string  ShowWarrantyInfo()
        {
            return "warrenty is " + this.warrentyYears + "Years";
        }
        public string ShowWarrantyInfo( string note)
        {
            return "warrenty is " + this.warrentyYears + "(" + note + ")";
        }



    }
}
