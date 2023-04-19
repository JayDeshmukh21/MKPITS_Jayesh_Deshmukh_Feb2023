using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Inheritance
{
    class person
    {
        public int id;
        public string name;
    }
    class student:person
    {
        public int rno;
        public string branch;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student no1 = new student();
            no1.id = 10;
            no1.name = "samkash";
            no1.rno = 21;
            no1.branch = "Civil";

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("id = " + no1.id);
            Console.WriteLine("name ="+no1.name);
            Console.WriteLine("roll no =" +no1.rno);
            Console.WriteLine("Branch ="+no1.branch);
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();

        }
    }
}
