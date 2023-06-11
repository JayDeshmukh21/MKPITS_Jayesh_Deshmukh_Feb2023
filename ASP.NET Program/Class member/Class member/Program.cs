using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_member
{
    internal class Program
    {
        // The class
        class MyClass
        {
            class Car
            {
                string model;
                string color;
                int year;

                static void Main(string[] args)
                {
                    Car Ford = new Car();
                    Ford.model = "Mustang";
                    Ford.color = "red";
                    Ford.year = 1969;

                    Car Opel = new Car();
                    Opel.model = "Astra";
                    Opel.color = "white";
                    Opel.year = 2005;

                    Console.WriteLine(Ford.model);
                    Console.WriteLine(Opel.model);
                    Console.ReadLine();
                }
            }
        }
    }
}
