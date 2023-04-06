using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num ={ 1, 2, 3, 4, 5 };
            Array.Clear(num, 0, 2);
            
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
                
            }
            Console.ReadLine();
        }
    }
}
