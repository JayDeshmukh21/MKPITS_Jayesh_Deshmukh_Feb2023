using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_3_element_by_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[3];
            arr[0] = 8.9f;
            arr[1] = 3.4f;
            arr[2] = 4.5f;
           

            foreach (float val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
