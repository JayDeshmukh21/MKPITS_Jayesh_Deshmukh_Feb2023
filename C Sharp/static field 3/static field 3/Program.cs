using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_3
{
    class Account
    {
        public int accountNo;
        public string name;
        public static float rateOfInterest;
        public Account(int accountNo, string name)
        {
            this.accountNo = accountNo;
            this.name = name;
            rateOfInterest++;
        }
        public void display()
        {
            Console.WriteLine("Account number = " + accountNo);
            Console.WriteLine("Name = " + name);
           // Console.WriteLine("Rate of Interest = " + rateOfInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account(103, "Jayesh");
            Account obj1 = new Account(219, "prasanna");
            obj.display();
            obj1.display();
            Console.WriteLine("no of object = " + Account.rateOfInterest);
            Console.ReadLine();


        }
    }
}
