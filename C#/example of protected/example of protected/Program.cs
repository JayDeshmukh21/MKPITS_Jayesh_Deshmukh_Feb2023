using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_protected
{

    class person
    {
        string name;
        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("name " + name);
        }
    }
    class employee : person
    {
        int empno;
        internal void getemployeedata(int empno, string name)
        {
            getpersondata(name);//calling base class method 
            this.empno = empno;
            Console.WriteLine("empno " + empno);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getemployeedata(1, "yasmin");

        }
    }
}
