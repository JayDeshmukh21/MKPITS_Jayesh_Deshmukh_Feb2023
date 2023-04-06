using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.class__employee_
{
    class employee
    {
        public int employee_id;
        public string employee_name;
        public int employee_salary;
        public string employee_department;

        public void getdata(string name)
        {
            employee_id = 1024;
            employee_name = name;
            employee_salary = 700000;
            employee_department = "Fendahl";
        }
        public void displaydata()
        {
            Console.WriteLine("Your id- "+ employee_id);
            Console.WriteLine("your name -" +employee_name);
            Console.WriteLine("salary -"+ employee_salary);
            Console.WriteLine("Dept. -" +employee_department);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee eg1=new employee();
            
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            
            eg1.getdata(name);
            eg1.displaydata();
            Console.ReadLine();
        }
    }
}
