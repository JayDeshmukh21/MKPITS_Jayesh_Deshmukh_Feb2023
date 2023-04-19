using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_between_1_to_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int outercounter = 1; outercounter <= 20; outercounter++)
            {
                int num=outercounter;
                int counter;
                int isprime = 0;
                for (counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    { 
                    isprime=1; 
                        break;
                    }
                }
                if (isprime == 0)
                { 
                    Console.WriteLine(num + "is prime no");
                
                }

            }
              
        }
    }
}
