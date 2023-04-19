using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_constructor_with_without_paramtr
{
    class product
    {
        int id;
        string name;
        string colour;
        int quantity;

        public product() 
        {
            id = 0;
            name = "laptop";
            colour = "red";
            quantity = 10;
        
        }
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
            product p = new product();
            p.displaydata();

            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();


            Console.WriteLine("enter colour");
            string colour = Console.ReadLine();


            Console.WriteLine("enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            product pro = new product(id, name, colour, quantity);
            pro.displaydata();
        }
    }
}
