using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_out_for_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius= ");
            int radius=Convert.ToInt32(Console.ReadLine());
            calculatearea(radius, out float area, out float circumferance);
            Console.WriteLine("area is = " + area);
            Console.WriteLine("circumferance = " + circumferance);
            Console.ReadLine();
        }
        static void calculatearea(int r, out float a, out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
