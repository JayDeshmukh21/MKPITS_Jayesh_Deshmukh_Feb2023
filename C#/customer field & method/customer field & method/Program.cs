using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_field___method
{
    class customer
    { 
         int id;
        string name;
        string address;

        public void getdata()
        {
            id = 12;
            name = "yasmin";
            address = "asdfghgfds";
        }

        public void displaydata()
        {
            Console.WriteLine("id " + id);
            Console.WriteLine("name " +name);
            Console.WriteLine("address " + address);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata();
            cust.displaydata();

        }
    }
}
