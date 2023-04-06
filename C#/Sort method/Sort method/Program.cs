using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 4, 8, 2, 3, };
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
