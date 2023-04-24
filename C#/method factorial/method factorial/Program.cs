using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,result;
            Console.WriteLine("enter number");
            number= Convert.ToInt32(Console.ReadLine());
             result = calculate_fact(number);
            Console.WriteLine("fact=" + result);
            Console.ReadLine(); 
            
        }
        static int calculate_fact( int i)
         
        {
            int fact = 1;
            while (i > 0)
            { 
             fact =fact * i;
                i--;
            }
            return fact;
        }
    }
}
