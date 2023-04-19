using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_product_constructor_parameter
{
    class product
    {
        int id;
        string name;
        string colour;
        int quantity;

        public product(int id, string name, string colour, int quantity)
        {
           this.id = id;
           this.name = name;
            this.colour = colour;
            this.quantity = quantity;

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
           
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();


            Console.WriteLine("enter colour");
            string colour = Console.ReadLine();


            Console.WriteLine("enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            product p = new product(id, name, colour, quantity);
            p.displaydata();

        }
    }
}
