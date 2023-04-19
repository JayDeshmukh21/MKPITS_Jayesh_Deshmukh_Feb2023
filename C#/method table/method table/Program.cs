using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            table(num);
        }
        static void table(int n1)
        {
            for (int i = 1; i <= 10; i++)
            {
                int cal = n1 * i;
                Console.WriteLine("{0}*{1}={2}" , n1,i,cal);

            }
        }
    }
}
