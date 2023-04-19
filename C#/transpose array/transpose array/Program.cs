using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transpose_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col, i, j;
            Console.Write("Enter the Order of the Matrix : ");

            Console.Write("Rows : ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            col = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpose Matrix : ");

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(A[j, i] + "\t");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
