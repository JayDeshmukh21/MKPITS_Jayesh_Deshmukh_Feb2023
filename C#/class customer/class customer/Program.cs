using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    class customer
    {
        public int id;
        public string name;
        public string address;
        public string city;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.id = 1;
            cust.name = "asad";
            cust.address = "asdfghhjkjhgfd";
            cust.city = "nagpur";

            Console.WriteLine("id : " + cust.id);
            Console.WriteLine("name : " +cust.name);
            Console.WriteLine("address : " +cust.address);
            Console.WriteLine("city : " + cust.city);
        }
    }
}
