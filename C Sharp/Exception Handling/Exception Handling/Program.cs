using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using Try And Catch Type of exceptrion handling

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = 10;
            int N2 = 0;
            int res = 0;
            try
            {
                res = N1 / N2;
                Console.WriteLine("Result =" + res);
            }
            catch(DivideByZeroException jb)
            {
                Console.WriteLine(jb.ToString());
                Console.ReadLine();
            }
        }
    }
}
