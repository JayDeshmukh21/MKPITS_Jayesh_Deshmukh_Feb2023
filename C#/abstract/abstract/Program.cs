using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract void deposit(int amt);
        public string showbalance()
        { 
         return "bal is" + bal;
        
        }
    
    }
    class Saving : Account
    {
        int interest= 500;
        public override void deposit(int amt) 
        {

            bal = bal + amt + interest;
            Console.WriteLine("deposited bal is" +  bal);
        }
    
    
    }
    class Current : Account
    { 
     public override void deposit(int amt) 
        
        {
            bal = bal+ amt;
            Console.WriteLine("deposited without interest , bal is " + bal);
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("enter amount");

            amount = Convert.ToInt32(Console.ReadLine());
            Account act = null;
            string Acttype;
            Console.WriteLine("Enter Method saving or current");
            Acttype = Console.ReadLine();
            if (Acttype == "saving")
            {

                act = new Saving();

            }
            else if (Acttype == "current") ;
            {

                act = new Current();
            }
            act.deposit(amount);
            string res = act.showbalance();
            Console.WriteLine(res);



        }
    }
}
