using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_with_field___method_with_parameter
{
    class employee
    {

        int id;
        string name;
        int number;
        string designation;

        public void getdata( int i,string n,int num,string des)
        {
            id = i;
            name = n;
            number = num;
            designation = des;

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
            emp.getdata(1, "Zoya",1234567890,"Manager");
            emp.displaydata();

        }
    }
}
