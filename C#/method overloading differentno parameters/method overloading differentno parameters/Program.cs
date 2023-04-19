using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_differentno_parameters
{
    class employee
    {
        int empno;
        string empname;

        public void getdata(int empno)
        {
            this.empno = empno;
            this.empname = "";
        }
        //overloading method
        public void getdata(int empno, string empname)
        {
            this.empno = empno;
            this.empname = empname;
        }
        public void display()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(123);
            emp.display();

            emp.getdata(33, "ravish");
            emp.display();
            Console.ReadLine();


        }
    }
}
