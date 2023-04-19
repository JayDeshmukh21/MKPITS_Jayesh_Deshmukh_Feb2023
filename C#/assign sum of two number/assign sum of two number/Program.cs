using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_sum_of_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, addition;
            Console.WriteLine("enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            addition = calculate_add(num1, num2);
            Console.WriteLine("addition is " + addition);

        }
        static int calculate_add(int n1, int n2)
        { 
           int sum = n1 + n2;
            return sum;
       
        }
    }
}
