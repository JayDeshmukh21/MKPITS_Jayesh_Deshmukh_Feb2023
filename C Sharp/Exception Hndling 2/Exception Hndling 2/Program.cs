using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Hndling_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 2;
            int res = 0;

            try
            {
                res = n1 / n2;
                Console.WriteLine("result = " + res);
            }
            catch(DivideByZeroException jb)
            {
                Console.WriteLine(jb.ToString());
            }
            finally
            {
                Console.WriteLine("Finally executed");
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
