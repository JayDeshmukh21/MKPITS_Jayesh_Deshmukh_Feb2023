using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add___sub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("enter number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("calling addition method");
            result=addition(num1,num2);
            Console.WriteLine("addition = " +  result);

            Console.WriteLine("calling subtraction method");
            result= subtraction(num1,num2);
            Console.WriteLine("subtraction = " + result);

            Console.ReadLine();


        }

        static int addition(int n1, int n2)
        {
        int result = n1 + n2;
            return result;
        }
        static int subtraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
    }
}
