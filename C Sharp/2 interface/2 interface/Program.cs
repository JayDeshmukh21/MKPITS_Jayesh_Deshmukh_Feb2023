using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//multiple Interface by inheritance

namespace _2_interface
{
    interface interface1
    {
        void method1();
    }
    interface interface2
    {
        void method2();
    }
    class class1: interface2
    {
        public void method1()
        {
            Console.WriteLine("Hello world from method 1");
        }
        public void method2()
        {
            Console.WriteLine("Yes I Can from method 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 b1 = new class1();
            b1.method1();
            b1.method2();
            Console.ReadLine();
        }
    }
}
