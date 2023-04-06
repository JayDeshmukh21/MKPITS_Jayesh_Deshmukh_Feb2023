using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int total = calculate(3,5,2,4,1,9,8);
            Console.WriteLine("TOTAL = " + total);
            Console.ReadLine();
        }
        static int calculate(params int[] val)
        {
            int total = 0;
            for (int count = 0; count<val.Length; count++)
            {
                total = total + val[count];

            }
            return total;
        }
    }
}
