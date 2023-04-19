using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_Reverse_the_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            // Swap elements from the start and end of the array, moving towards the center
            for (int i = 0, j = numbers.Length - 1; i < j; i++, j--)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            Console.WriteLine("Reversed array elements: " + string.Join(", ", numbers));
            Console.ReadLine();
        }
    }
}
