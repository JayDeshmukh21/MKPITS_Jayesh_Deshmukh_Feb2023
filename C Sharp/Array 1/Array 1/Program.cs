using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr=new string[2];
            arr[0] = "Rajesh";
            arr[1] = "Ram";
            foreach (string val in arr)
            {
                Console.WriteLine(val);
                Console.ReadLine();
            }
        }
    }
}
