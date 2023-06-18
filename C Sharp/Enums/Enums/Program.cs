using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        enum Level
        {
            Low,
            Max,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Max;
            Console.WriteLine(myVar);
            Console.ReadLine();
        }
    }
}
