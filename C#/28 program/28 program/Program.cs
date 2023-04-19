using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even number");
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine(num + " is Odd number");
            }
            else 
            { 
              Console.WriteLine("neither even nor odd");
            }
            Console.ReadLine();
        }
    }
}
