using System;


namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            int length,breadth,area;
            Console.WriteLine("please enter length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;

            Console.WriteLine("Area of rectangle is " + area);
            Console.ReadKey();
        }
    }
}
