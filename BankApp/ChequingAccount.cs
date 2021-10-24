using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ChequingAccount : Account
    {
        public ChequingAccount(double currentBalance, double interestRate) : base(currentBalance, interestRate)
        {

        }
        public override void Withdraw(double amount)
        {
            if (this.currentBalance - amount < 0)
            {
                this.currentBalance -= 15.00;
                Console.WriteLine("insufficient funds poor guy we taking $15 gg");
            }
            else if (this.currentBalance - amount > 0)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("something happend chequing account withdraw");
            }
        }
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        public override string CloseAndReport()
        {
            this.serviceCharge += this.numOfDeposits * 0.1 + 5;

            return base.CloseAndReport();
        }

    }
}
