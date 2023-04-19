using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = Fun(5, 3);
            Console.WriteLine(res);
        }
        static int Fun(int x, int y) 
        {

            if (y <= 0)
            {
                return 1;
            }
            else
            { 
            return x + Fun(x, y-1);
            }
        }
    }
}
