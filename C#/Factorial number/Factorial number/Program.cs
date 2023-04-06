using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling factorial method");
            result = factorial(num);
            Console.WriteLine("factorial  is = " + result);
            Console.ReadLine();
        }
        static int factorial(int n1)
        {
            int fact = 1, i = 1;
            while(i <= n1) 
            {
                fact = fact * i;
                i++;
                
            }
            return fact;
        }
    }
}
