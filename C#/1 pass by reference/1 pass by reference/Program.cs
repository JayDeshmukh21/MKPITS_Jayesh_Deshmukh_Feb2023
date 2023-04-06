using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pass_by_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area = 0.0f;
            float circumference= 0.0f;
            Console.WriteLine("enter radius = ");
            radius=Convert.ToInt32(Console.ReadLine());
            calculatearea(radius,ref area, ref circumference);
            Console.WriteLine("area = " + area);
            Console.WriteLine("circumference = " + circumference);
            Console.ReadLine();

        }
        static void calculatearea(int r, ref float a, ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
            
        }
        
    }
}
