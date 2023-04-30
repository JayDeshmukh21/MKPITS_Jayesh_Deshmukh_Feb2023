using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// use abstraction to calculate NetSalary and GrossSalary

namespace Abstraction
{
    class Employee
    {
        public int Empid;
        public string Empname;
        public double Grosspay;
        double TaxDeduction = 0.1;
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            Empid = Eid;
            Empname = Ename;
            Grosspay = Egrosspay;
        }
        void calculateSalary()
        {
            if (Grosspay>=50000)
            {
                netSalary = Grosspay - (TaxDeduction * Grosspay);
                Console.WriteLine("Your salary is = "+netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is = " + Grosspay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("The year of 2023");
            calculateSalary();
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(123, "jay", 59000);
            obj.ShowEmployeeDetails();
            Console.ReadLine();
            
        }
    }
}
