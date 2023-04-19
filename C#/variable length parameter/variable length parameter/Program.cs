using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_length_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
            total = calculate(3, 5, 7, 8, 9);
            Console.WriteLine("total " +total);
            Console.ReadLine();
        }
        static int calculate(params int[] val)
        {
            int counter, total = 0;
            for (counter = 0; counter < val.Length; counter++)
            { 
            total += val[counter];
            }
            return total;
        }
    }
}
