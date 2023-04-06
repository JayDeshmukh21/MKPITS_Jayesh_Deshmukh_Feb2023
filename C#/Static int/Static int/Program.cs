using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling function");
            int result = calculatesquare();
            Console.WriteLine("square = " + result);
            Console.ReadKey();
        }
        static int calculatesquare()
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            return square;
        }

    }
}


