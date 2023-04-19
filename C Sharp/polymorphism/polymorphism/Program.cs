using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class account
    {
        public int bal=1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposite method of account class");
        }
    }
    class saving :account
    {
        int interest=500;
        public override void deposit (int amt)
        {
            bal = bal + amt + interest;
            Console.WriteLine("deposite bal is " + bal);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act =new saving();
            act.deposit(200);
            Console.ReadLine();
        }
    }
}
