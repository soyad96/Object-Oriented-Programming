using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assicment2
{
    class Program
    {
        static void Main(string[] args )
        {
            Product p1 = new Product();
            p1.ProductId = 123456;
            p1.Name = "Charger";
            p1.Price = 1250.50d;
            p1.ShowDetails();
            Product p2 = new Product(135789, "Juice", 150.75d);
            p2.ShowDetails();
            //Console.ReadKey();
            DiscountedProduct d1 = new DiscountedProduct();
            d1.ProductId = 145907;
            d1.Name = "Light";
            d1.Price = 1440.89d;
            d1.DiscountedPercent = 10.0;
            d1.Category = "Winter";
            DiscountedProduct.VatRate = 10.0;
            d1.ShowDetails();
            Console.WriteLine(d1.GetFinalPrice());
            Console.WriteLine(d1.HasSeasonalOffer("Winter"));
            DiscountedProduct d2 = new DiscountedProduct(243622, "Punjabi", 2050.50d, 18.0d, "Festiable");
            d2.ShowDetails();
            Console.WriteLine(d2.GetFinalPrice());
            Console.WriteLine(d2.HasSeasonalOffer("Festiable"));
            PremiumProduct pre= new PremiumProduct();
            pre.ProductId = 897076;
            pre.Name = "Rolex";
            pre.Price = 150000.45d;
            pre.WarrentyYears = 10;
            pre.CountryOfOrigin = "Swis";
            pre.ShowDetails();
            Console.WriteLine(pre.IsEligibleForVIPReturn());
            Console.WriteLine(pre.ShowWarrantyInfo());
            Console.WriteLine(" the werranty is "+pre.ShowWarrantyInfo(" have to hurry "));
            PremiumProduct pre2 = new PremiumProduct(256890, "I phone", 120000d, 1, "USA");
            pre2.ShowDetails();
            Console.WriteLine(pre2.IsEligibleForVIPReturn());
            Console.WriteLine(pre2.ShowWarrantyInfo());
            Console.WriteLine("the product has " + pre2.WarrentyYears + pre2.ShowWarrantyInfo(" have to hurry "));
            Console.ReadKey();

        }
    }
}
