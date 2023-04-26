using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person");
        }
    }
    class student : person
    {
        public sealed override void display()
        {
            Console.WriteLine("student");
        }
    }
    class paststudent : person
    {
        public void pshow()
        {
            Console.WriteLine("Pshow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            paststudent obj = new paststudent();
            obj.display();
            obj.pshow();
            Console.ReadLine();
        }
    }
}
