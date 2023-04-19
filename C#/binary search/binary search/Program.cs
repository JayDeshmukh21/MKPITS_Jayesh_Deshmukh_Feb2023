using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16 };

            Console.Write("Enter a number to search for: ");
            int target = int.Parse(Console.ReadLine());

            int result = BinarySearch(numbers, target);

            if (result == -1)
            {
                Console.WriteLine("The number {0} was not found.", target);
            }
            else
            {
                Console.WriteLine("The number {0} was found at index {1}.", target, result);
            }

            Console.ReadLine();
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == target)
                {
                    return middle;
                }
                else if (arr[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

    }
}

