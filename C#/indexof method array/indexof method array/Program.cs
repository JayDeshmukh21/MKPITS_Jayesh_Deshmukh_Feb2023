using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexof_method_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 2, 4 };

            int l = Array.IndexOf(num, 3);
            Console.WriteLine("index  " + l);

        }
    }
}
