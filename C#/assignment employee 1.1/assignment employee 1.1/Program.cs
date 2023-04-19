using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_employee_1._1
{
    class employee
    {
        public int id;
        public string name;
        public int number;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.id = 1;
            emp.name = "Zoya";
            emp.number = 1234567890;
            emp.designation = "Manager";

            Console.WriteLine("id : " +  emp.id);
            Console.WriteLine("name : " + emp.name);
            Console.WriteLine("number : " + emp.number);
            Console.WriteLine("designation : " + emp.designation);
            
        }
    }
}
