using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggrigation
{
    class address
    {
        public string city;
        public string state;

        public address(string city, string state)
        {
            this.city = city;
            this.state = state;
        }
    }
    class employee
    {
        int empNo;
        string name;
        address add;

        public employee(int empNo, string name, address add)
        {
            this.empNo = empNo;
            this.name = name;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(empNo);
            Console.WriteLine(name);
            Console.WriteLine(add.city);
            Console.WriteLine(add.state);
        }
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            address j1 = new address("Dubai", "Pune");
            employee j2 = new employee(21, "Jayesh", j1);
            j2.display();
            Console.ReadLine();
        }
    }
}
