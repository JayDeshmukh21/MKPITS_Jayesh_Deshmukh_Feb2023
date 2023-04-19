using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_parameter_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int result = calculate_square(n1);
            Console.WriteLine("square = " + result);
            Console.ReadKey();
        }
        static int calculate_square(int num)
        {
            int square = num * num;
            return square;
        }
    }
}
