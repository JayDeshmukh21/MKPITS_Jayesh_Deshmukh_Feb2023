using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int flag = 0;
            int count = 2;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (num % count == 0)

                {
                    flag = 1;
                    break;
                }
                count++;
            }wNhile(count < num);


            if (flag == 0)
            {
                Console.WriteLine(num + " is prime no");
            }
            else
            {
                Console.WriteLine(num + " is Not a prime no");
            }
        }
    }
}
