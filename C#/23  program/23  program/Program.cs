using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23__program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeename;
            int basicsalary, hra, da, totalsallary;
            long employeeno;
            Console.WriteLine("enter  name");
            employeename = Console.ReadLine();
            Console.WriteLine("enter number");
            employeeno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter basicsallary");
            basicsalary = Convert.ToInt32(Console.ReadLine());
            hra = (basicsalary * 32) / 100;
            da = (basicsalary * 45) / 100;
            totalsallary = basicsalary + hra + da;
            Console.WriteLine("Name:" + employeename);
            Console.WriteLine("mobno:" + employeeno);
            Console.WriteLine("hra=" + hra);
            Console.WriteLine("da=" + da);
            Console.WriteLine("totalsallary=" + totalsallary);
            Console.ReadLine();
        }
    }
}
