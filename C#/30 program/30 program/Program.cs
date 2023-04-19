using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("enter empname ");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation ");
            designation = Console.ReadLine();
            switch (designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;

                default:
                    Console.WriteLine("invalid designation");
                    break;
            }

            Console.WriteLine("empname ={0} , bonus = {1} ", empname, bonus);
        }
    }
}
