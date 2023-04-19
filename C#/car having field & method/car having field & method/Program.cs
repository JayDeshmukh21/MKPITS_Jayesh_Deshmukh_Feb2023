using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_having_field___method
{
    class car
    {
        int number;
        string name;
        string colour;

        public void getdata()
        {
            number = 123;
            name = "abc";
            colour = "white";
        }

        public void displaydata()
        {
            Console.WriteLine("number " + number);
            Console.WriteLine("name " + name);
            Console.WriteLine("colour " +  colour);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.getdata();
            car1.displaydata();

        }
    }
}
