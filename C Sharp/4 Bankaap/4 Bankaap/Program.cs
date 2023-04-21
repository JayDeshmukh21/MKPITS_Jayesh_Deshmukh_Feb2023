using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Bankaap
{
    internal class Program
    {
        interface IAccount
        {
            string deposit(int amt);
        }
        abstract class Account : IAccount
        {
            public int balance = 2000;
            public abstract string deposit(int amt);
            public string showbalance()
            {
                return "Balance is "+balance.ToString();
            }
        }
        class saving : Account
        {
            int interest = 500;
            public override string deposit(int amt)
            {
                balance += amt + interest;
                return "Amount deposited with interest bal is " + balance;
            }
        }
        class current : Account
        {
            public override string deposit(int amt)
            {
                balance += amt;
                return "Amount is deposited without Balance is " + balance;
            }
        }
        static void Main(string[] args)
        {
            Account act = null;
            string accounttype;
            Console.WriteLine("Enter account type");
            
            accounttype = Console.ReadLine();
            Console.WriteLine("Enter Amount To be...");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            if(accounttype == "saving")
            {
                act = new saving();
            }
            else if(accounttype == "current")
            {
                act = new current();
            }
            string res = act.deposit(amount);
            Console.WriteLine(res);
            Console.WriteLine(act.showbalance());

        }
    }
}
