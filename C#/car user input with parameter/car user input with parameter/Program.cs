using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_user_input_with_parameter
{
    class car
    {
        int number;
        string name;
        string colour;

        public void getdata(int num, string n, string col)
        {
            number = num;
            name = n;
            colour = col;


        }

        public void displaydata()
        {
            Console.WriteLine("number " + number);
            Console.WriteLine("name " + name);
            Console.WriteLine("colour " + colour);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter colour");
            string colour = Console.ReadLine();

            car1.getdata(number, name, colour); 
            car1.displaydata();
        }
    }
}
