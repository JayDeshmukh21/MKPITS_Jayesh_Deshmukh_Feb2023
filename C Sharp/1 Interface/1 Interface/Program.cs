using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Interface
{
    interface interface1
    {
        void method1();
    }
    class class1 : interface1
    {
        public void method1()
        {
            Console.WriteLine("Hello world from method 1");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            interface1 a1 = new class1();
            a1.method1();
            Console.ReadLine();
        }
    }
}
