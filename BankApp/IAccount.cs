using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);
        void CalculateInterest();
        string CloseAndReport();
    }
}
