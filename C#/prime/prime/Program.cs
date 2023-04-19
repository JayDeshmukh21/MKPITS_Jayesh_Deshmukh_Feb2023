using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int counter;
            int isprime = 0;
            for (counter = 1; counter < num; counter++)
            {
                if (num % counter == 0)
                { 
                isprime = 1;
                    break; 
                }
            }
            if (isprime == 0)
            {
                Console.WriteLine("it is prime no");
            }
            else 
            {
                Console.WriteLine("it is not prime no");
                    
            }
        }
    }
}
