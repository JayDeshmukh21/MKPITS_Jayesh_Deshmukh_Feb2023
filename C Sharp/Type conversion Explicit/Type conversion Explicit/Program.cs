using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In explicit function data may or may not lose...

namespace Type_conversion_Explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 91.25f;
            int b = (int)a;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
