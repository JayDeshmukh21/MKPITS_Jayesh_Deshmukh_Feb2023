using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getlength_method_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 3, 5, 1, 2, 4 ,5};

            int l = num.GetLength(0);
            Console.WriteLine("length " + l);

        }
    }
}
