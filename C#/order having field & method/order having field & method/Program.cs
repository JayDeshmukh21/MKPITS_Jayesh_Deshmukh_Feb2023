using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_having_field___method
{
    class order
    {
        public int number;
        public string name;
        public int price;

        public void getdata()
        { 
          number = 0;
            name = "yashu";
            price = 0;
        
        }

        public void displaydata()
        { 
        Console.WriteLine("number " +  number);
            Console.WriteLine("name " +  name);
            Console.WriteLine("price " +  price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order ord = new order();
            ord.getdata();
            ord.displaydata();
        }
    }
}
