using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_object
{
    internal class Program
    {
        class Car
        {
            string color = "red";

            static void Main(string[] args)
            {
                Car myObj = new Car();
                Console.WriteLine(myObj.color);
                Console.ReadLine();
            }
        }
    }
}
