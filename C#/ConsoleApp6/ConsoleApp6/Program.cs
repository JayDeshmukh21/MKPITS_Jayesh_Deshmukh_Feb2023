using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class employee
    {

        int id;
        string name;
        int number;
        string designation;

        public void getdata(int i, string n, int num, string des)
        {
            id = i;
            name = n;
            number = num;
            designation = des;

        }

        public void displaydata()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("name : " + name);
            Console.WriteLine("number : " + number);
            Console.WriteLine("designation : " + designation);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee empl = new employee();
            Console.WriteLine("enter id ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter designation");
            string designation = Console.ReadLine();

            empl.getdata(id, name, number, designation);
            empl.displaydata();
        }
    }
}
