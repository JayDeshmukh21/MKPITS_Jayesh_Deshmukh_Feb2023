using System;
namespace Program
{
    class Program
    {
        static void Main()
        {
            int num1,num2,num3, add;
            Console.Write("Enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2 + num3;

            Console.WriteLine("Addition is : " + add);
            Console.ReadKey();

        }
    }
}