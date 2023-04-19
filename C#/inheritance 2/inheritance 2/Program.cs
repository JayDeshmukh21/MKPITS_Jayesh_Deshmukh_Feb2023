using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_2
{
    class Employee
    {
        public int salary = 12000;
    }
    class programmer:Employee
    {
        public int bonus = 9000;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p1 = new programmer();
            Console.WriteLine("-------------------------");
            Console.WriteLine("salary = " + p1.salary);
            Console.WriteLine("Bonus  = " + p1.bonus);
            Console.WriteLine("-------------------------");
            Console.ReadLine();
        }
    }
}
