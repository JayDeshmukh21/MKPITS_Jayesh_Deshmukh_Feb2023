using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_9_find_common_element_btwn_two_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };
            int[] commonElements = new int[array1.Length]; // Assuming array1 and array2 have the same length
            int count = 0;

            // Loop through each element in array1 and check if it is present in array2
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        commonElements[count++] = array1[i];
                        break;
                    }
                }
            }

            Console.WriteLine("Common elements: " + string.Join(", ", commonElements));
            Console.ReadLine();
        }
    }
}
