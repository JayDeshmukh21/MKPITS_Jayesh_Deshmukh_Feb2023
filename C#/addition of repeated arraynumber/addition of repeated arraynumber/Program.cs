using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace addition_of_repeated_arraynumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            
            int sum = 0;
            
            int i = 0;
            
            int index = Array.IndexOf(arr, size - 1);
            int counter = 0;

            Additionofarraynumber(arr, counter, sum);

            Console.ReadKey();
        }
        static void Additionofarraynumber(int[] arr, int counter, int sum)
        {
            for (int array_initialize = 0; array_initialize < arr.Length; array_initialize++)
            {
                Console.WriteLine("Enter number " + (array_initialize + 1) + "=");
                arr[array_initialize] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (i > j || j > i)
                        {
                            counter++;

                        }
                    }
                }
            
            if (counter > 0)
            {
                if (i == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("+");
                }
                Console.Write(arr[i]);
                sum += arr[i];
            }
            counter = 0;
        }
            Console.WriteLine("=" + sum);
            Console.ReadKey ();

        }
    }
}
