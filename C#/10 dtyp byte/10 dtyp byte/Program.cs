using System;

namespace _10_dtyp_byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b1;
            Console.WriteLine("enter bite : ");
            b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte entered = " + b1);

            Console.Readkey();

        }
    }
}
