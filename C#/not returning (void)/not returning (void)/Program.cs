using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_returning__void_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,result;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("calling addition method");
            addition(num1, num2);


            Console.WriteLine("calling substraction method");
            substraction(num1, num2);
            Console.ReadLine();
        }
        static void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Addition = " + result);
        }
        static void substraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine("Substraction = " + result);
        }
    }
}


