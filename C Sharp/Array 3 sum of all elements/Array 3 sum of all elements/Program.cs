using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3_sum_of_all_elements
{
    internal class Program
    {

        static void Main()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            // Loop through each element in the array and add it to the sum
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Sum of array elements: " + sum);
            Console.ReadLine();
        }

    }
}

