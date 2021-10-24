using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    abstract class Account : IAccount
    {
        public double startBalance { get; set; }
        public double currentBalance { get; set; }
        protected double depositTotal;
        protected int numOfDeposits;
        protected double withdrawTotal;
        protected int numOfWithdraws;
        protected double interestRate;
        protected double serviceCharge;
        protected AccountEnum Activity { get; set; }
        public Account(double currentBalance, double interestRate)
        {
            this.currentBalance = currentBalance;
            this.interestRate = interestRate;
        }
        public void CalculateInterest()
        {
            double monthlyInterestRate = (this.interestRate / 12);
            double monthlyInterest = this.currentBalance * monthlyInterestRate;
            this.currentBalance += monthlyInterest;
        }

        public virtual string CloseAndReport()
        {
            double newBalance = this.currentBalance - this.serviceCharge;
            CalculateInterest();
            this.numOfDeposits = 0;
            this.numOfWithdraws = 0;
            this.serviceCharge = 0;

            return "Previous Balance: "+this.currentBalance+ "\n New Balance: "+newBalance+"\n % Change: "+this.startBalance/this.currentBalance;

        }

        public virtual void Deposit(double amount)
        {
            this.currentBalance += amount;
            this.numOfDeposits++;
        }

        public virtual void Withdraw(double amount)
        {
            this.currentBalance -= amount;
            this.numOfWithdraws++;
        }
    }
}
