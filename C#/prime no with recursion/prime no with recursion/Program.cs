using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_no_with_recursion
{
    internal class Program
    {

        public static int Main()
        {
            int n1, primeNo;
            Console.Write(" Input any  number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            primeNo = checkForPrime(n1, n1 / 2);//call the function checkForPrime

            if (primeNo == 1)
                Console.Write(" The number {0} is a prime number. \n\n", n1);
            else
                Console.WriteLine(" The number {0} is not a prime number. \n\n", n1);
            return 0;
        }

        static int checkForPrime(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n1 % i == 0)
                    return 0;
                else
                    return checkForPrime(n1, i - 1);//calling the function checkForPrime itself recursively
            }

        }

    }
}
