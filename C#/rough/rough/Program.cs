using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rough
{
    internal class Program
    {

        static string str = "proffession";
        static int n = str.Length;
        static string repeated = "";
        static int cnt = 0;
        
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        repeated = repeated + str[i];     
                   
                        cnt = cnt + 1;
                        break;

                    }
                }
            }
           
            Console.WriteLine("Repeated chars are: " + repeated);
            Console.WriteLine("No of repeated chars are: " + cnt);
        }
    }
}

