using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingsAccount : Account
    {
        public SavingsAccount(double currentBalance, double interestRate) : base(currentBalance,interestRate)
        {
          
        }
        public override void Withdraw(double amount) 
        {
            if (this.Activity == AccountEnum.ACTIVE)
            {
                base.Withdraw(amount);
                if (this.currentBalance < 25)
                {
                    Activity = AccountEnum.INACTIVE;
                }
            }
            else if(Activity == AccountEnum.INACTIVE)
            {
                Console.WriteLine("Your Savings Account is inactive, Savings Account must be atleast $25 \n Current Balance : " + this.currentBalance);
            }
            else
            {
                Console.WriteLine("account enum not set(Savings account withdraw");
            }
        }

        public override void Deposit(double amount)
        {
            if(this.Activity == AccountEnum.INACTIVE)
            { 
                    if(this.currentBalance + amount >= 25)
                    {
                         base.Deposit(amount);
                        this.Activity = AccountEnum.ACTIVE;
                        
                    }
                    else
                    {
                         base.Deposit(amount);
                        
                    }
                
            }
            else if(this.Activity == AccountEnum.ACTIVE)
            {
                base.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Account enum not set (SAVINGS ACCOUNT DEPOSIT)");
            }

        }
        public override string CloseAndReport()
        {
            if (this.numOfWithdraws > 4)
            {
                this.serviceCharge = this.numOfWithdraws - 4;
                return base.CloseAndReport();
            }
            else if(this.numOfDeposits<=4)
            {


                return base.CloseAndReport();
            }

            else
            {
                Console.WriteLine("Service charge not calculated savings account closeAndReport");
                return base.CloseAndReport();
            }
        }



    }
}
