using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_order
{
    class order
    {
       public int number;
       public string name;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order ord = new order();
            ord.number = 123;
            ord.name = "abc";
            ord.price = 100;
            Console.WriteLine("number " + ord.number);
            Console.WriteLine("name " + ord.name);
            Console.WriteLine("price " + ord.price);

        }
    }
}
