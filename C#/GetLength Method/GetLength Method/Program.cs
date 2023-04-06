using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLength_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 4, 8, 2, 3, };
           int l=num.GetLength(0);
            Console.WriteLine("lenght is = " + l);
            Console.ReadLine();
        }
    }
}
