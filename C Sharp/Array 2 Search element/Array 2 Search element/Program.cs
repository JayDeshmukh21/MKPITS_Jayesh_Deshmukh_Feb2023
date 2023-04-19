using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2_Search_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isfound = false;
            int[] arr= { 1, 2, 3 };
            Console.WriteLine("Enter number to be search");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int count=0;count<arr.Length; count++)
            {
                if (arr[count] == num)
                {
                    isfound = true;
                    break;
                }
            }
            if(isfound==true)
            {
                Console.WriteLine(num + "is found in array");
            }
            else
            {
                Console.WriteLine(num + "Is not found");
            }
            Console.ReadLine();
        }
    }
}
