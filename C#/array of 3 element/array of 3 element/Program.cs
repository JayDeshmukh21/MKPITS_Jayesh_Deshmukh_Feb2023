using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_3_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            //display the array element
            foreach(int i in arr)
            {
                Console.WriteLine("num " + i);
            }
        }
    }
}
