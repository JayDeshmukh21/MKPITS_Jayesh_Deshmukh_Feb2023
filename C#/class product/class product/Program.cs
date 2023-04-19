using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product
{
    class product
    { 
        public int id;
        public string name;
        public string colour;
        public int quantity;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product pro = new product();
            pro.id = 1;
            pro.name = "laptop";
            pro.colour = "silver";
            pro.quantity = 100;

            Console.WriteLine("id : " + pro.id);
            Console.WriteLine("name : " + pro.name);
            Console.WriteLine("colour : " + pro.colour);
            Console.WriteLine("quantity : "+ pro.quantity);
        }
    }
}
