using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clear_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int[] num = { 3, 5, 1, 2, 4 };

            Array.Clear(num, 0, 2);

            //display the values of array
            for (int i = 0; i < num.Length; i++)
            {

                Console.Write(num[i] + "\t");

            }




        }
    }
}
