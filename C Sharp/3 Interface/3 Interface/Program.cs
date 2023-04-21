using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//interface using baseclass...
namespace _3_Interface
{
    interface interface1
    {
        void method1();
    }
    class baseclass
    {
        public void basemethod()
        {
            Console.WriteLine("Hello from baseclass");
        }
    }

        class class1: baseclass, interface1
        {
            public void method1()
            {
                Console.WriteLine("Hello from method 1");
            }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.method1();
            c1.basemethod();
            Console.ReadLine();
        }
    }
}
