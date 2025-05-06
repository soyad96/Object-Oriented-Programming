using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assicment1
{
   public  class BankAccount
    {
        protected int accountNumber;
        protected string holderName;
        protected double balance;
        public static int totalAccounts = 0;
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string  HolderName
        {
            get { return this.holderName; }
            set { this.holderName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public BankAccount()
        {
            totalAccounts++;
        }
        public BankAccount(int accountNumber,string holderName,double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName=holderName;
            this.balance = balance;
            totalAccounts++;
        }
        public  virtual void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("  this is the details you have been looking. ");
            Console.WriteLine(" the account number  is: " + this.accountNumber);
            Console.WriteLine(" the account holder name :   is " + this.holderName);
            Console.WriteLine(" the account has  :" + this.balance);
            Console.WriteLine(" the total account number is : " + BankAccount.totalAccounts);
        }
    }
}
