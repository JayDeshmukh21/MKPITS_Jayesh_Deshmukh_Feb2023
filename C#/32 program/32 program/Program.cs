using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, basic;
            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter basic");
            basic = Convert.ToInt32(Console.ReadLine());
            float hra = 0;
            float da = 0;
            switch (basic)
            {
                case 25000:
                    hra = basic * 0.32f;
                    da = basic * 0.45f;
                    break;
                case 50000:
                    hra = basic * 0.22f;
                    da = basic * 0.55f;
                    break;
            }
            float total = basic + hra + da;
            Console.WriteLine("empno " + empno);
            Console.WriteLine("hra " + hra);
            Console.WriteLine("da " + da);
            Console.WriteLine("total salary " + total);
        }
    }
}
