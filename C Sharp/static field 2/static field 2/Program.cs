using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Creat a class employee having field empno, name and static field company name and constructor and disply method
// then creat two object

namespace static_field_2
{
    class Employee
    {
        public int empNo;
        public string name;
        public static string companyName = "Fendahal";

        public Employee(int empNo, string name)
        {
            this.empNo = empNo;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Employee number = " + empNo);
            Console.WriteLine("Employee name = "+name);
            Console.WriteLine("Employee comapany name = "+companyName);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(1, "Jayesh Deshmukh");
            Employee obj1 = new Employee(2, "Neha Thakur");
            obj.display();
            obj1.display();
            Console.ReadLine();
        }
    }
}
