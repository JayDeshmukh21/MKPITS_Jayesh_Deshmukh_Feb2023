using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    public class calculate
    {
        public static float pi;

        static calculate()
        {
            pi = 3.14f;
            Console.WriteLine("The static constructor.");
        }
        public void display()
        {
            Console.WriteLine("rate of interest = " + pi);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            calculate j1 = new calculate();
            calculate p1 = new calculate();
            j1.display();
            p1.display();
            Console.ReadLine();
        }
    }
}
