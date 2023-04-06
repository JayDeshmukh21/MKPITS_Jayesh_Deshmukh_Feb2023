using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_of_a_number
{
    internal class Program
    {
    
        public static void Main()
        {
            int j, n;

            Console.Write("Enter number");
            Console.Write("Enter number = ");
            Console.Write("");
            Console.Write("\n\n");

            Console.Write("Input the number (Table to be calculated) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }
}
