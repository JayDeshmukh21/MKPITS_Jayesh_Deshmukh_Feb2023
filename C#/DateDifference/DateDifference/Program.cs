using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2023, 6, 1);
            DateTime date2 = new DateTime(2023, 6, 15);

            TimeSpan difference = date2 - date1;

            Console.WriteLine("The difference between the two dates is: {0} days.", difference.Days);
            Console.ReadLine();




            Console.WriteLine("Enter the Birth date (yyyy-MM-dd):");
            DateTime date3 = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second date (yyyy-MM-dd):");
            DateTime date4 = DateTime.Now;

            TimeSpan diff = date4 - date3;

            Console.WriteLine("Days upto now is: {0} days.", diff.Days);
            Console.ReadLine();





            Console.WriteLine("Enter the birth date (yyyy-MM-dd):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }

            Console.WriteLine("The age is: {0} years.", age);
            Console.ReadLine();

        }
    }
}
