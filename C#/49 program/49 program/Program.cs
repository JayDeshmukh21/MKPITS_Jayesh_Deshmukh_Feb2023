using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int answer = 0;
            do
            {
                Console.WriteLine("enter value");
                string line = Console.ReadLine();
                guess = int.Parse(line);
            }
            while (guess != answer);

        }
    }
}
