using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_7_find_2nd_smallest_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 4 };
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            // Loop through each element in the array and keep track of the smallest and second smallest elements
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = numbers[i];
                }
                else if (numbers[i] < secondSmallest && numbers[i] != smallest)
                {
                    secondSmallest = numbers[i];
                }
            }

            Console.WriteLine("Second smallest element: " + secondSmallest);
            Console.ReadLine();
        }
    }
}
