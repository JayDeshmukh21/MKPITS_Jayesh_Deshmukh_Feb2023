using System;
namespace Helloprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square of number is " + square);
            Console.ReadKey();
        }
    }
}