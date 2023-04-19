using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_6_Avg_of_all_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            // Loop through each element in the array and add it to the sum
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Calculate the average by dividing the sum by the number of elements
            double average = (double)sum / numbers.Length;

            Console.WriteLine("Average of array elements: " + average);
            Console.ReadLine();
        }
    }
}
