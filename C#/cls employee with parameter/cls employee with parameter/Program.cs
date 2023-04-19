using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_employee_with_parameter
{
    class employee
    {
        int id;
        string name;
        int number;
        string designation;

        public employee(int id, string name, int number, string designation)
        {
           this. id = id;
           this. name = name;
           this.number = number;
            this. designation = designation;

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
           
            Console.WriteLine("enter id ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter designation");
            string designation = Console.ReadLine();

            employee empl = new employee(id,name,number,designation);
            empl.displaydata();
        }
    }
}


