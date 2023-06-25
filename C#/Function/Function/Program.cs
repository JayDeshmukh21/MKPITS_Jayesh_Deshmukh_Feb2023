using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = AddNumbers(num1, num2);
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
