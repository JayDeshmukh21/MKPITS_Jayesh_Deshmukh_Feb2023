using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_initialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5,6,7,8 };
            for(int i =0; i<num.Length; i++) 
            {
                Console.WriteLine("num {0} = {1}", i , num[i]);
            }

        }
    }
}
