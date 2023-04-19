using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            for (row = 3; row > 0; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*"+ "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
