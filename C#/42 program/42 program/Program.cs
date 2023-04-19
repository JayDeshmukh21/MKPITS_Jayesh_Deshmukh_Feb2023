using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {

                fact = fact * num;

                num--;

            }
            while (num > 0);
            Console.WriteLine("fact = " + fact);
        }
    }
}
