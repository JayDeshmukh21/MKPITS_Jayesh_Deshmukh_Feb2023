using System;
using System.Xml.Linq;

namespace Program
{
    class Program
    {
        static void Main()
        {
            int roll, age, contact;
            string name, course;

            Console.WriteLine("Enter roll no : ");
            roll=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name : ");
            name=Console.ReadLine();

            Console.WriteLine("Enter age : ");
            age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter course : ");
            course=Console.ReadLine();

            Console.WriteLine("Enter contact no. : ");
            contact= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(roll);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(course);
            Console.WriteLine(contact);
            Console.ReadKey();
        }
    }
}