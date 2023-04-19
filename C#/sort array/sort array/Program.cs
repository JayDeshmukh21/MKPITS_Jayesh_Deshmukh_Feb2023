using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 2, 4 };
            Array.Sort(num);


            //display the values of array
            for (int i = 0; i < num.Length; i++)
            {

                Console.Write(num[i] + "\t");

            }
            Console.ReadKey();

        }
    }
}
