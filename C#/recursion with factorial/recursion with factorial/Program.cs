using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_with_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int res = fact(num);
            Console.WriteLine("fact = " +res);
        }

        static int fact(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num*fact(num-1);
            }
        }
    }
}
