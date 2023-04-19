using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_product_without_parameter
{
    class product
    {
        int id;
        string name;
        string colour;
        int quantity;

        public product()
        {
            id = 1;
            name = "laptop";
            colour = "silver";
            quantity = 12;

        }
        public void displaydata()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("name : " + name);
            Console.WriteLine("colour : " + colour);
            Console.WriteLine("quantity : " + quantity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product product = new product();
            product.displaydata();
        }
    }
}
