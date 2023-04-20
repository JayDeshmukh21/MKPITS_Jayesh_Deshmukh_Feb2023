using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class animal
    {
        public void eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }
    class Dog:animal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating....");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog tommy=new Dog();
            tommy.eat();
            Console.ReadLine();
        }
    }
}
