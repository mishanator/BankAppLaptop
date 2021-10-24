using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class GlobalSavingsAccount : SavingsAccount
    {
        public GlobalSavingsAccount(double currentBalance, double interestRate) : base( currentBalance, interestRate)
        {

        }
        public double USValue()
        {
            return this.currentBalance * 0.75;
        }
    }
}
