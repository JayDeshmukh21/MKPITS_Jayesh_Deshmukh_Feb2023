using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_user_input_with_parameter
{
    class order
    {
        int number;
        string name;
        int price;

        public void getdata(int num, string n, int p)
        {
            number = num;
            name = n;
            price = p;

        }

        public void displaydata()
        {
            Console.WriteLine("number " + number);
            Console.WriteLine("name " + name);
            Console.WriteLine("price " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            order ord = new order();
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());    

            ord.getdata(number, name, price);
            ord.displaydata();
        }
    }
}
