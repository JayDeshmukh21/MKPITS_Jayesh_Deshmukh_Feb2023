using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_with_field_method___parameter
{
    class customer
    {
        int id;
        string name;
        string address;

        public void getdata(int i , string n, string add)
        {
            id = i;
            name = n;
            address = add;

        }

        public void displaydata()
        { 
         Console.WriteLine("id : " +  id);
            Console.WriteLine("name  : " +  name);
            Console.WriteLine("address :" +  address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(1, "yasmin", "zacds");
            cust.displaydata();
        }
    }
}
