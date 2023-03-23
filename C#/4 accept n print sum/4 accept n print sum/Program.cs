using System;
namespace Program
{
    class Program
    {
        static void Main()
        {
            int num1, num2, sum;
            Console.Write("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            
            num2=Convert.ToInt32(Console.ReadLine());
            sum= num1 + num2;
            Console.WriteLine("addition of two number is : " + sum);
            Console.ReadLine();

        }
    }
}