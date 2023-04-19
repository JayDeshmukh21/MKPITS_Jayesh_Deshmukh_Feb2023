using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_without_parameter
{
    class student
    {
        int rno;
        string name;
        //creating a constructor
        public student()
        {
            rno = 999;
            name = "rajesh";
        }
        public void displaydata()
        {

            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();// it will call constructor

            stud1.displaydata();

        }
    }
}
