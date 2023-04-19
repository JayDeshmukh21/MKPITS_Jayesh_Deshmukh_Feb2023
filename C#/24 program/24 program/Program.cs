using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, designation;
            long empno, bonus = 0;

            Console.WriteLine("enter name");
            empname = Console.ReadLine();
            Console.WriteLine("enter mobileno");
            empno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter designation as manager,clerk,peon");
            designation = Console.ReadLine();
            if (designation == "manager")
            {
                bonus = 10000;
                Console.WriteLine("your bonus is 10000");
            }
            else if (designation == "clerk")
            {
                bonus = 5000;
                Console.WriteLine("your bonus is 5000");
            }
            else if (designation == "peon")
            {
                bonus = 2000;
                Console.WriteLine("your bonus is 2000");
            }
            else { Console.WriteLine("invalid designaion"); }
            Console.ReadLine();
        }
    }
}
