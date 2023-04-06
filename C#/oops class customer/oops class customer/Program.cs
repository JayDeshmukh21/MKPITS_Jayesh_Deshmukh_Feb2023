using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_class_customer
{
    class customer
    {
        public string name;
        public int id;
        public string address;
        

        public void getdata(string n, int num, string adr)
        {
            name = n;
            id = num;
            address = adr;
            
        }
        public void displaydata()
        {
            Console.WriteLine("customer name- " + name);
            Console.WriteLine("ID           - " + id);
            Console.WriteLine("Address      - " + address);
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer jp1 = new customer();
            Console.WriteLine("New Customer Registration");

            Console.Write("Enter Customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter address :");
            string address= Console.ReadLine();
            

            jp1.getdata(name,id,address);
            jp1.displaydata();
            Console.ReadLine();
        }
    }
}

