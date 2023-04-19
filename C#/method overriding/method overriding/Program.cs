using System;

namespace method_overriding
{

    class Account
    {
        public int bal = 1000;
        public void deposit(int amt)
        {

            Console.WriteLine("deposit method of Account class ");
        }
    
    }

    class Saving : Account
    {

        int interest = 500;
        public void deposit(int amt)
        { 
        bal = bal + amt+ interest ;
            Console.WriteLine("deposit bal is " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         Saving s = new Saving();
            s.deposit(200);
        }
    }
}
