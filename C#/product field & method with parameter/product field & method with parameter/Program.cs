using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_field___method_with_parameter
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
        Console.WriteLine("id : " +  id);
            Console.WriteLine("name : " +  name);
            Console.WriteLine("colour : " +  colour);
            Console.WriteLine("quantity : " +  quantity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            p.getdata(123, "laptop", "silver", 1230);
            p.displaydata();
        }
    }
}
