using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace example_of_this_keyword
{
    class student
    { 
    int rno;
    string name;
    //creating member functions
    public void getdata(int rno, string name)
    {
        this.rno = rno;
        this.name = name;
    }
    public void displaydata()
    {

        Console.WriteLine("rno " + rno);
        Console.WriteLine("name " + name);
    }
}


internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            Console.WriteLine("enter rno");
            int rno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();

            stud1.getdata(rno, name);
            stud1.displaydata();

        }
    }
}
