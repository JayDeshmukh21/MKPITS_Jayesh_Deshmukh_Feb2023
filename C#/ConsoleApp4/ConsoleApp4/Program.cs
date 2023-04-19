using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num1, num2,num3, add;
            Console.WriteLine("please enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number2");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number2");
            num3 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2 + num3;
            Console.WriteLine("Addition of a number is " + add);
            Console.ReadKey();
        }
    }
}

