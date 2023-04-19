using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_as_a_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter string");
            name=Convert.ToString(Console.ReadLine());
            length(name);
        }
        static void length(string name)
        {
            int len = name.Length;
            Console.WriteLine("length = " + len);
        }


    }
}
