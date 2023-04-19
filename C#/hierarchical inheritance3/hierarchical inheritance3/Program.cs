using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance3
{

    class account
    {
        public int actno;
        public int bal = 1000;
        public void deposit(int amt)
        {
            Console.WriteLine("this is deposit method of account class");
        }
    }
    class saving : account
    {
        //override the deposit method
        public void deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("amount deposited with interest bal is " + bal);
        }

    }

    class current : account
    {
        //override the deposit method
        public void deposit(int amt)
        {

            bal = bal + amt;
            Console.WriteLine("amount deposited without interest bal is " + bal);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            saving s = new saving();
            s.actno = 111;
            s.deposit(1000);

            current c = new current();
            c.actno = 121;
            c.deposit(1000);

        }
    }
}
