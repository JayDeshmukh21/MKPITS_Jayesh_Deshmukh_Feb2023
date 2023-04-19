using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, cir;
            Console.WriteLine("Enter radius");
            radius=Convert.ToInt32(Console.ReadLine());
            area = 0.0f;
            cir = 0.0f;
            calculate_area(radius, ref area, ref cir);
            Console.WriteLine("area " + area);
            Console.WriteLine("circumference " + cir);
            Console.ReadLine();
        }
        static void calculate_area(int r, ref float a, ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
        
    }
}
