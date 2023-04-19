using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_square
{
    internal class Program
    {
        static void Main() 
        {
            Console.WriteLine("calling method");
            int result = calculate_square();
            Console.WriteLine("square = " + result);
        }
        static int calculate_square()
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            return square;
        }
    }
}
