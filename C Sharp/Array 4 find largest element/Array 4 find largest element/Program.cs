using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4_find_largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5,2,8,9,6,3 };
            int max = numbers[0];

                // Loop through each element in the array and compare it with the current max
            for (int i = 1; i < numbers.Length; i++)
            {
               if (numbers[i] > max)
               {
                 max = numbers[i];
               }
            }
            Console.WriteLine("Largest element in the array: " + max);
            Console.ReadLine();
        }
        

    }
}
