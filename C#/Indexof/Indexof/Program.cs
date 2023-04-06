using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 5, 4, 8, 2, 3, };
            int l = Array.IndexOf(num,8);
            Console.WriteLine("length is = " + l);
            Console.ReadLine();
        }
    }
}
