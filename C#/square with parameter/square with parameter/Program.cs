using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_with_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            square(num);
           
            Console.ReadLine();
        }
        static void square(double number)

        {
            Console.WriteLine("square of " + number + "=" + number * number);
          
        
        }
    }
}
