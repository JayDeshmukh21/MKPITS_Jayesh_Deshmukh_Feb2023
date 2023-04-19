using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i); //0 1 2 3 4
                i++; //5
                if (i < 5)
                    continue; // will skip remaing statement and go for next iteration
                else
                    break; //will come out of the loop
            }
            Console.WriteLine("bye");
        }
    }
}
