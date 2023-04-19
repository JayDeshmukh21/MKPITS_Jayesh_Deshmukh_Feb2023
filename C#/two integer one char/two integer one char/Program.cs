using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_integer_one_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char op;
            Console.WriteLine("Enter number");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter  + , - ,");
            op=Convert.ToChar(Console.ReadLine()); 
            calculate(n1,n2,op);
            Console.ReadKey();
            

        }
        static void calculate(int n1, int n2, char op)
        {
            
        
        }
    }
}
