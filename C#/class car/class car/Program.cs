using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_car
{
    class car
    {
        public int number;
        public string name;
        public string colour;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.number = 9551;
            car1.name = "abc";
            car1.colour = "white";
            Console.WriteLine("number : " + car1.number);
            Console.WriteLine("name: "+car1.name);
            Console.WriteLine("colour : " + car1.colour);
            Console.ReadLine();
        }
    }
}
