using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searched_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isfound=false;
            int[] arr = {1,2,3};
            int num;
            Console.WriteLine("Enter number to be searched");
            num = Convert.ToInt32(Console.ReadLine());
            for (int counter = 0; counter < arr.Length; counter++)
            { 
            if (arr[counter] == num) 
                {
                    isfound = true;
                    break;
                }
            }
            if (isfound== true) 
            {
                Console.WriteLine(num + " is found in array");
            }
            else
            { 
                Console.WriteLine(num + " is  not found in array"); 
            }
            Console.ReadLine();
        }
    }
}
