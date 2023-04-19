using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_student
{

    public class Person
    {
        public String name;
        public String address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class\
            p1.rno = 123;
            p1.name = "yasmin";
            p1.address = "Nagpur";
            p1.marks = 88;

            Console.WriteLine("rno: " + p1.rno);
            Console.WriteLine("name: " + p1.name);
            Console.WriteLine("address: " + p1.address);
            Console.WriteLine("marks: " + p1.marks);

        }
    }
}
