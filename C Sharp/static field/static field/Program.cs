using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace static_field
{
    class Account
    {
        public int accountNo;
        public string name;
        public static float rateOfInterest= 9.1f ;
        public Account(int accountNo, string name)
        {
            this.accountNo = accountNo;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Account number = " + accountNo);
            Console.WriteLine("Name = "+name);
            Console.WriteLine("Rate of Interest = "+rateOfInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account(103,"Jayesh");
            obj.display();
            Console.ReadLine();
            

        }
    }
}

