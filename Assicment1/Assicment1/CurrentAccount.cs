using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assicment1
{
     public class CurrentAccount:BankAccount
    {
        private double overdraftLimit;
        private double transactionsFee;
        public double OverDraftLimit
        {
            get { return this.overdraftLimit; }
            set { this.overdraftLimit = value; }
        }
        public double TrasactionFee
        {
            get { return this.transactionsFee; ; }
            set { this.transactionsFee = value; }
        }
        public CurrentAccount():base()
        {

        }
        public CurrentAccount(int accountNumber, string holderName, double balance, double overdraftLimit,double transactionsFee):base(accountNumber,  holderName,  balance)
        {
            this.overdraftLimit = overdraftLimit;
            this.transactionsFee = transactionsFee;
        }
        public override  void ShowDetails()
            
        {
            base.ShowDetails();
            Console.WriteLine(" the overdraftLimit is"+this.overdraftLimit);
            Console.WriteLine(" the transactionsfees is " + this.transactionsFee);

        }
        public bool CanWithDraw (double ammount)
        {
            if (ammount <= this.balance + this.overdraftLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanWithDraw(double ammount,double fee)
        {
            if (ammount <=this. balance - fee + this.overdraftLimit)
            {
                return true;
            }
            else return false;
        }
    }
}
