using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 2, 4 };

            int[] num1 = (int[])num.Clone();


            //display the values of array
            for (int i = 0; i < num1.Length; i++)
            {

                Console.Write(num1[i] + "\t");

            }

        }
    }
}
