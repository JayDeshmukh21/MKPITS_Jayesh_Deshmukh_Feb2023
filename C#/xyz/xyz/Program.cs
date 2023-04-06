using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            for(int i =1;i<= height;i++)
            {
                for(int j =1;j<=height-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write("*");
                }Console.ReadLine();
            }
        }
    }
}
