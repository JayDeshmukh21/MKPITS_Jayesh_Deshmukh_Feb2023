using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_field___method_with_parameter
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
        Console.WriteLine("number " +  number);
            Console.WriteLine("name " + name);
            Console.WriteLine("colour " +  colour);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.getdata(9551,"abc" , "white");
            car1.displaydata();

        }
    }
}
