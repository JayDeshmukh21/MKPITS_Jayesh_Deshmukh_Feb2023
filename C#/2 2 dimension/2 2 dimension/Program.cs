using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_dimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter number");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            // display the value
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(num[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }
    }
}
