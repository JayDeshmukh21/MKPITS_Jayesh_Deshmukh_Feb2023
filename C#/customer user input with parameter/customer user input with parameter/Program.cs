using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_user_input_with_parameter
{
    class customer
    {
        int id;
        string name;
        string address;

        public void getdata(int i, string n, string add)
        {
            id = i;
            name = n;
            address = add;

        }

        public void displaydata()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("name  : " + name);
            Console.WriteLine("address :" + address);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter address");
            string address = Console.ReadLine();

            cust.getdata(id, name, address);
            cust.displaydata();
        }
    }
}
