using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance1
{
    class person
    {
        public string name;
        public string address;

    }
    class student : person
    {
        public int rno;
        public int marks;

    }
    class employee : person
    {
        public int salary;
        public string designation;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "yasmin";
            s.address = "nagpur";
            s.rno = 44;
            s.marks = 999;
            Console.WriteLine("--------------- student details ----------");
            Console.WriteLine("name " + s.name);
            Console.WriteLine("addres " + s.address);
            Console.WriteLine("rno " + s.rno);
            Console.WriteLine("marks " + s.marks);


            //creating object of empclass
            employee emp = new employee();
            emp.name = "yashu";
            emp.address = "mumbai";
            emp.salary = 55544;
            emp.designation = "manager";
            Console.WriteLine("--------------- emp details ----------");
            Console.WriteLine("name " + emp.name);
            Console.WriteLine("addres " + emp.address);
            Console.WriteLine("salary " + emp.salary);
            Console.WriteLine("designation " + emp.designation);

        }
    }
}
