using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor3
{
    internal class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
               this.model = modelName;
                this.color = modelColor;
                this.year = modelYear;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
                Console.ReadLine();
            }
        }
    }
}
