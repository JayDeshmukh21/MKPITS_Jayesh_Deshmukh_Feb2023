using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_user_input
{
    class product
    {
        int id;
        string name;
        string colour;
        int quantity;

        public void getdata(int i, string n, string col, int quant)
        {
            id = i;
            name = n;
            colour = col;
            quantity = quant;

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
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();


            Console.WriteLine("enter colour");
            string colour = Console.ReadLine();


            Console.WriteLine("enter quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            p.getdata( id,name,colour,quantity);
            p.displaydata();

        }
    }
}
