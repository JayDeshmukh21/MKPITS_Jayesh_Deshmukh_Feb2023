using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            Console.WriteLine("Enter num2");
            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(" num1 is greater");
            }
            else 
            {
                Console.WriteLine("num2 is greater");
            }
            Console.ReadKey();

        }
    }
}
