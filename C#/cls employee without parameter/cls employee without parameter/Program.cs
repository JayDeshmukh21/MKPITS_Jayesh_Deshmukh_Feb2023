using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_employee_without_parameter
{
    class employee
    {
        int id;
        string name;
        int number;
        string designation;

        public employee() 
        {
            id = 123;
            name = "yashu";
            number = 1234567890;
            designation = "manager";

        }

        public void displaydata()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("name : " + name);
            Console.WriteLine("number : " + number);
            Console.WriteLine("designation : " + designation);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.displaydata();
            
        }
    }
}
