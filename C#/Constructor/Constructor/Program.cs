using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class order
    {
        public int orderno;
        public string orderdate;
        public string productname;
        public int productrate;
        public int quantity;

        public void getdata(int no, string date, string name, int rate, int qty)
        {
            orderno = no;
            orderdate = date;
            productname = name;
            productrate = rate;
            quantity = qty;
        }

        public void displaydata()
        {
            Console.WriteLine("---------------Amezon.in---------------");
            Console.WriteLine("Order number -" + orderno);
            Console.WriteLine("Order Date -" + orderdate);
            Console.WriteLine("Product name -" + productname);
            Console.WriteLine("Product rate -" + productrate);
            Console.WriteLine("Product quantity -" + quantity);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order product = new order();
            Console.WriteLine("Enter number - ");
            int num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Date - ");
            string date=Console.ReadLine();

            Console.WriteLine("Product name - ");
            string name=Console.ReadLine();

            Console.WriteLine("Rate -");
            int rate=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantity - ");
            int qty=Convert.ToInt32(Console.ReadLine());

            product.getdata(num, date, name, rate, qty);
            product.displaydata();
            Console.ReadLine();
        }
    }
}
