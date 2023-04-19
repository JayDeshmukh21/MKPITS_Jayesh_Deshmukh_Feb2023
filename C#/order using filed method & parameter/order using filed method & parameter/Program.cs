using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_using_filed_method___parameter
{
    class order
    {
         int number;
         string name;
        int price;

        public void getdata( int num , string n, int p)
        {
            number = num;
            name = n;
            price = p;

        }

        public void displaydata()
        {
            Console.WriteLine("number " + number);
            Console.WriteLine("name " + name);
            Console.WriteLine("price " + price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            order ord = new order();
            ord.getdata(1123, "abc", 100);
            ord.displaydata();
        }
    }
}
