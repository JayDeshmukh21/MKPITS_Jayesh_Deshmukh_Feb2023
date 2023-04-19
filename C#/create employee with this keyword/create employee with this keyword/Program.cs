using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace create_employee_with_this_keyword
{
    class employee
    { 
    int id;
    string name;
    int number;
    string designation;

    public void getdata(int id, string name, int number, string designation)
    {
        this.id = id;
        this.name = name;
        this.number = number;
        this.designation = designation;

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
            emp.getdata(12,"yashu",123456,"manager");
            emp.displaydata();  
        }
    }
}
