using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace recursion_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = myfunct(5,3);
            Console.WriteLine(res);
        }
        static int myfunct(int a,int b)
        {
            if (b <= 0)
            {
                return 1;

            }
            else 
            { 
            
             return a * myfunct(a,b-1);
            }
            
            
        }
        
    }
}
