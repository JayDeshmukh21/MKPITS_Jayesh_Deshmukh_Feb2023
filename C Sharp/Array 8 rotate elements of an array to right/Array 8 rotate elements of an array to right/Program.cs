using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_8_rotate_elements_of_an_array_to_right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int rotateBy = 2;

            // Create a temporary array to store the rotated elements
            int[] rotated = new int[numbers.Length];

            // Loop through each element in the original array and calculate the new index after rotation
            for (int i = 0; i < numbers.Length; i++)
            {
                int newIndex = (i + rotateBy) % numbers.Length;
                rotated[newIndex] = numbers[i];
            }

            Console.WriteLine("Original array: " + string.Join(", ", numbers));
            Console.WriteLine("Rotated array: " + string.Join(", ", rotated));
            Console.ReadLine();
        }
    }
}
