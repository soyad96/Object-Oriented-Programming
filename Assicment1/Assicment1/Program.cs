using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assicment1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 3457890;
            b1.HolderName = "Soyad Rahman ";
            b1.Balance = 1234.56d;
            b1.ShowDetails();
            BankAccount b2 = new BankAccount(456239, "Siam hossian ", 1456.90d);
            b2.ShowDetails();
            SavingAccount s1 = new SavingAccount();
            s1.AccountNumber = 123456;
            s1.HolderName = "Md Rakib";
            s1.Balance = 1056.89d;
            s1.InterestRate = 4.5d;
            s1.MinimumBalance = 850.78d;
            s1.ShowDetails();
           Console.WriteLine( " the annual interest rate of s1 account is "+s1.CalculateAnnualInterest());
            Console.WriteLine(s1.IsPenaltyApplicable());
            SavingAccount s2 = new SavingAccount(145678, "MUNNA ", 1618.78d, 6.6d, 1050.8d);
            s2.ShowDetails();
            Console.WriteLine(" the annual interest rate of the s2 account is " + s2.CalculateAnnualInterest());
            Console.WriteLine(s2.IsPenaltyApplicable());
            CurrentAccount c1 = new CurrentAccount();
            c1.AccountNumber = 345689;
            c1.HolderName = "Rehan gazi";
            c1.Balance = 356.89d;
            c1.OverDraftLimit = 400.0d;
            c1.TrasactionFee = 50.0d;
            c1.ShowDetails();
            Console.WriteLine(c1.CanWithDraw(123.0d));
            Console.WriteLine(c1.CanWithDraw(123.0d, 50.0d));
            CurrentAccount c2 = new CurrentAccount(162535, "Aminul ", 3459.9d, 100.0d,35.0d);
            c2.ShowDetails();
            Console.WriteLine(c2.CanWithDraw(111.0d));
            Console.WriteLine(c2.CanWithDraw(111.0d,40.0d));
            Console.ReadKey();
        }
    }
}
