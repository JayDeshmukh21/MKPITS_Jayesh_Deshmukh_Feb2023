using System;


namespace _8__accept_radius_print_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("enter radius : ");
            radius = Convert.ToInt32(Console.ReadLine());
            float area= 3.14F * radius * radius;
            Console.WriteLine("AREA : " + area);
            float circ = 2 * 3.14F * radius;
            Console.WriteLine("CIRCUMFERENCE : " + circ);
            Console.ReadLine();

        }
    }
}
