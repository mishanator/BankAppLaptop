using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(5,0);
            ChequingAccount ca = new ChequingAccount(5, 0);
            GlobalSavingsAccount gsa = new GlobalSavingsAccount(5, 0);
            bool go = true;
            while (go)
            {
                Console.WriteLine("Bank Menu Home \n A: Savings \n B: Chequing \n C: Global Savings \n Q: Exit");
                string option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Savings Menu \n A: Deposit \n B: Withdrawal \n C: Close & Report \n R: Return to Bank Menu");
                        string optionS = Console.ReadLine();
                        switch (optionS.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("Enter amount to deposit into Savings");
                                double amount1 = Double.Parse(Console.ReadLine());
                                sa.Deposit(amount1);
                                Console.WriteLine("Current Balance: $" + sa.currentBalance);
                                break;
                            case "B":
                                Console.WriteLine("Enter amount to withdraw from Savings");
                                double amount2 = Double.Parse(Console.ReadLine());
                                sa.Withdraw(amount2);
                                Console.WriteLine("Current Balance: $" + sa.currentBalance);
                                break;
                            case "C":
                                sa.CloseAndReport();
                                break;
                            case "R":
                                break;
                            default:
                                Console.WriteLine("invalid thing i think?");
                                break;
                        }
                        break;
                    case "B":
                        Console.WriteLine("Chequing Menu \n A: Deposit \n B: Withdrawal \n C: Close & Report \n R: Return to Bank Menu");
                        string optionC = Console.ReadLine();
                        switch (optionC.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("Enter amount to deposit into chequing");
                                double amount1 = Double.Parse(Console.ReadLine());
                                ca.Deposit(amount1);
                                Console.WriteLine("Current Balance: $" + ca.currentBalance);
                                break;
                            case "B":
                                Console.WriteLine("Enter amount to withdraw from Savings");
                                double amount2 = Double.Parse(Console.ReadLine());
                                ca.Withdraw(amount2);
                                Console.WriteLine("Current Balance: $" + ca.currentBalance);
                                break;
                            case "C":
                                sa.CloseAndReport();
                                break;
                            case "R":
                                break;
                            default:
                                Console.WriteLine("invalid thing i think?");
                                break;
                        }

                        break;
                    case "C":
                        Console.WriteLine("Global Savings Menu \n A: Deposit \n B: Withdrawal \n C: Close & Report \n D: Report Balance in USD \n R: Return to Bank Menu");
                        string optionG = Console.ReadLine();
                        switch (optionG.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("Enter amount to deposit into Savings");
                                double amount1 = Double.Parse(Console.ReadLine());
                                gsa.Deposit(amount1);
                                Console.WriteLine("Current Balance: $" + gsa.currentBalance);
                                break;
                            case "B":
                                Console.WriteLine("Enter amount to withdraw from Savings");
                                double amount2 = Double.Parse(Console.ReadLine());
                                gsa.Withdraw(amount2);
                                Console.WriteLine("Current Balance: $" + gsa.currentBalance);
                                break;
                            case "C":
                                gsa.USValue();
                                break;
                            case "D":
                                gsa.CloseAndReport();
                                break;
                            case "R":
                                break;
                            default:
                                Console.WriteLine("invalid thing i think?");
                                break;
                        }
                        break;
                    case "Q":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
