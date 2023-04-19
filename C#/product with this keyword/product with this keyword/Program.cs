using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_with_this_keyword
{
    class product
    {
        int id;
        string name;
        string colour;
        int quantity;

        public void getdata(int id, string name, string colour, int quantity)
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
            product pro = new product();
            pro.getdata(1,"laptop","silver",100);
            pro.displaydata();
            
        }
    }
}
