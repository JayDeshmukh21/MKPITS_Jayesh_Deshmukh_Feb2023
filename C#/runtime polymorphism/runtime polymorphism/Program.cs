using System;

namespace method_overriding
{

    class Account
    {
        public int bal = 1000;
        public virtual void deposit(int amt)
        {

            Console.WriteLine("deposit method of Account class ");
        }

    }

    class Saving : Account
    {

        int interest = 500;
        public override void deposit(int amt)
        {
            bal = bal + amt + interest;
            Console.WriteLine("deposit bal is " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal=bal+ amt;
            Console.WriteLine("deposited without interest bal is : " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter amount");
            amount=Convert.ToInt32(Console.ReadLine());
            Account act = null;
            string Acttype;
            Console.WriteLine("enter Acttype cuttent or saving");
            Acttype = Console.ReadLine();
            if (Acttype == "saving")
            {
                act = new Saving();

            }
            else if (Acttype == "current")
            { 
            act = new Current();
            
            }
            act .deposit(amount);   

        }
       
    }
}
