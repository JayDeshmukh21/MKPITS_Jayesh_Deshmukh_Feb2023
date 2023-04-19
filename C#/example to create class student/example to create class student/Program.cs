using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_to_create_class_student
{
    class student
    {
        public int rno;
        public string name;
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.rno = 123;
            stud1.name = "yasmin";
            Console.WriteLine("rno " + stud1.rno);
            Console.WriteLine("name " + stud1.name);

            student stud2 = new student();
            stud2.rno = 124;
            stud2.name = "yashu";
            Console.WriteLine("rno " + stud2.rno);
            Console.WriteLine("name " + stud2.name);
        }
    }
}
