using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class person
    {
        public string name;
        public string address;

        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;

        }

        public void display()
        {
            Console.WriteLine("name  : " + name);
            Console.WriteLine("address : " + address);

        }
    
    }

    public class employee:person
    { 
    public int empno;
        public int salary;

        public void getdata(int empno, int salary,string name,string address)
        {
           
            this.empno = empno;
            this.salary = salary;
            getdata(name, address);
            
        }

        public void display()
        { 
            base.display();
            Console.WriteLine("empno : " + empno);
            Console.WriteLine("salary : " +  salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(12, 1200000, "yashu", "asdffghj");
            emp.display();
            Console.ReadKey();

        }
    }
}
