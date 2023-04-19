using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                
                fact = fact * num;
                num--;

            }
            Console.WriteLine("fact = " + fact);
        }
    }
}
