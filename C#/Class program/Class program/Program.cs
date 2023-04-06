using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("calling the method display");
            display();
            Console.WriteLine("again calling display");
            display();
        }
        static void display()
        {
            Console.WriteLine("Hello world");
        }
    }
}
