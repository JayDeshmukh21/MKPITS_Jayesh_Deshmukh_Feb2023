using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_a_new_child_class_from_person_class
{
    class person
    {
        public string name;
        public string address;

    }

    class employee : person
    {

        public int empno;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.empno = 1;
            emp.name = "yasmin";
            emp.address = "nagpur";
            emp.salary = 50000;
            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.name);
            Console.WriteLine("emp addres " + emp.address);
            Console.WriteLine("emp salary " + emp.salary);

        }
    }
}
