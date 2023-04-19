using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_not_returning_a_value
{
    internal class Program
    {
        static void Main()
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2, result;
            Console.WriteLine("enter number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("calling addition method");
             addition(num1, num2);
            

            Console.WriteLine("calling subtraction method");
             subtraction(num1, num2);
            

            Console.ReadLine();


        }

        static void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("addition is " + result);
        }
        static void subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("substraction is " + result);

        }
    }
}
