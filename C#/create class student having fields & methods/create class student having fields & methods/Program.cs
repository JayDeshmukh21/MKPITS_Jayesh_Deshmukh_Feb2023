using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace create_class_student_having_fields___methods
{
    internal class Program
    {
        class student
        {
            int rno;
            string name;

            public void getdata()
            {
                rno = 123;
                name = "yasmin";
            }

            public void displaydata()
            {
                Console.WriteLine("rno " + rno);
                Console.WriteLine("name " + name);
            }
        }
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.getdata();
            stud1.displaydata();
        }
    }
}
