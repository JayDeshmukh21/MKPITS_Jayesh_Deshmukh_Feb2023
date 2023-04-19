using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_display
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calling method display");
            display();
            Console.WriteLine("again calling display");
            display();

        }
        static void display()
        {
            Console.WriteLine("Hello World"); 
        }
    }
}
