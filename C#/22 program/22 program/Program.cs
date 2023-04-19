using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            Console.WriteLine("Enter num3");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(" num1 is smallest");
            }
            if (num2 < num3)
            {
                Console.WriteLine(" num2 is smallest");
            }
            else
            {
                Console.WriteLine("num3 is smallest");
            }
            Console.ReadKey();
        }
    }
}
