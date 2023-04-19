using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_field
{
    class employee
    {
        protected int salary;

    }
    //creating a derieved class programmer
    class programmer : employee
    {
        int bonus;
        public void getdata(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary " + salary);
            Console.WriteLine("bonus " + bonus);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            p.getdata(23000, 5000);
            p.displaydata();
        }
    }
}
