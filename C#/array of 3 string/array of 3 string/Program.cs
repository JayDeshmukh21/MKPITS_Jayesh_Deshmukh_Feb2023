using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_3_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            arr[0] = "yasmin";
            arr[1] = "jay";
            arr[2] = "tanmay";
            arr[3] = "sahil";

            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
