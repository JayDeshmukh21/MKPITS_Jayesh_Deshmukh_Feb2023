using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_upto_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter = 1; outercounter < 50; outercounter++)
            {
                int num = outercounter;
                int yasmin = 0;
                for (int counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                        yasmin =1;
                        break;
                    }
                }
                    if (yasmin == 0)
                    {
                        
                        Console.WriteLine(num + "is prime no");
                        Console.ReadLine();
                    }
                
            }
            
        }
    }
}
