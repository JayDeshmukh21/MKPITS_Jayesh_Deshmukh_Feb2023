using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Object
{
    internal class Program
    {
        class Car
        {
            string color = "red";
            static void Main(string[] args)
            {
                Car myObj1 = new Car();
                Car myObj2 = new Car();
                Console.WriteLine(myObj1.color);
                Console.WriteLine(myObj2.color);
                Console.ReadLine();
            }
        }
    }
}
