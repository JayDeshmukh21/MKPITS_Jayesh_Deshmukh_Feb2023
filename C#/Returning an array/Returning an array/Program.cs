using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returning_an_array
{
    internal class Program
    {
        static int[] returnarray()
        {
            int[] num = { 1, 5, 4, 8, 2, 3 };
            return num;
        } 
        static void Main(string[] args)
        {
            int[] arr = returnarray();
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
            
        

    }
        
}
