using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = new string[3];
            num[0] = "amit";
            num[1] = "raj";
            num[2] = "dilip";
            
            foreach (string i in num)
            {
                Console.WriteLine(i);
            }

        }
    }
}
