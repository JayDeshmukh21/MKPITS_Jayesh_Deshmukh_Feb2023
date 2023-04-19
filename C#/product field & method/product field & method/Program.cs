using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_field___method
{
    class product
    {
         int id;
         string name;
       string colour;
        int quantity;

        public void getdata()
        {
            id = 1;
            name = "laptop";
            colour = "red";
            quantity = 10;
        }

        public void displaydata()
        { 
        Console.WriteLine("id : " +  id);
            Console.WriteLine("name : " + name);
            Console.WriteLine("colour : " +  colour);
            Console.WriteLine("quantity : " +  quantity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();  
            
            p.getdata();
            p.displaydata();
        }
    }
}
