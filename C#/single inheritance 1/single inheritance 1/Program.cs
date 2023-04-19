using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_1
{
    class person
    {
        public string name;
    }

    class student : person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rno = 1;
            s.name = "yasmin";
            Console.WriteLine("rno " + s.rno);
            Console.WriteLine("name " + s.name);
        }
    }
}
