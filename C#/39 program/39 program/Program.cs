using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int res = 1;
            int i = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;
            }
            while (i <= 10);
        }
    }
}
