using System;


namespace _3_program
{
    class Program
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square of a number is " + square);
            Console.ReadKey();

        }
    }
}
