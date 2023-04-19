using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_diffno.parameter
{

    class employee
    {
        int empno;
        string empname;

        public void getdata(string empname, int empno)
        {
            this.empno = empno;
            this.empname = "arjun";
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
            emp.getdata("arjun", 111);
            Console.WriteLine("-------------employee 1 detais : -------------");
            emp.display();

            employee emp1 = new employee();
            emp1.getdata(33, "ravish");
            Console.WriteLine("-------------employee 2 detais : -------------");
            emp1.display();
            Console.ReadLine();

        }
    }
}
