using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class program
    {
         public void sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            program obj=new program();
            obj.sum(10.2f,10.8f);
            Console.ReadLine();
        }
    }
}
