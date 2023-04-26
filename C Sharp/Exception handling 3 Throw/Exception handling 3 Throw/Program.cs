using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_3_Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            try
            {
                Console.WriteLine("Enter age =");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0 || age < 100)
                {
                    throw new Exception("Enter proper age");
                }
                else
                {
                    Console.WriteLine("your age is =" + age);
                }

            }
            catch (Exception jb)
            {
                Console.WriteLine(jb.ToString());

            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }

    }
}
