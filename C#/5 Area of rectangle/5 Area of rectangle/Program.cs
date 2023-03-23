using System;
namespace Program
{
    class Program
    {
        static void Main()
        {
            int length, breadth, area;
            Console.Write("Enter length : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth : ");

            breadth = Convert.ToInt32(Console.ReadLine());
            area= length * breadth;
            Console.WriteLine("Area of rectangle is : " + area);
            Console.ReadKey();

        }
    }
}