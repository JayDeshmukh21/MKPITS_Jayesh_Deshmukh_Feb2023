using System;


namespace ConsoleApp3
{
     class Program
    {
        static void Main()
        {
            int rollno, age;
            double mobileno;
            String name, course;

            Console.WriteLine("please enter roll no:");
            rollno = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("please enter name:");
            name= Console.ReadLine();
           

            Console.WriteLine("please enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("please enter course:");
            course = Console.ReadLine();

            Console.WriteLine("please enter Mobile no:");
            mobileno = Convert.ToDouble(Console.ReadLine());
         

            Console.WriteLine("your roll no is:-" + rollno);
            Console.WriteLine("your name is:-" + name);
            Console.WriteLine("your age is:-" + age);
            Console.WriteLine("your course is:-" + course);
            Console.WriteLine("your mobile no is:-" + mobileno);

            Console.ReadKey();

        }
    }
}
