using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_2
{
    class Week
    {
        public enum Days
        {
            Monday, Tuesday, Wednesday, Friday, Sunday
        }
        public void number_Of_Days()
        {
            Console.WriteLine("monday =" + (int)Days.Monday);
            Console.WriteLine("Wednesday =" +(int)Days.Wednesday);
            Console.WriteLine("Tuesday =" + (int)Days.Tuesday);
            Console.WriteLine("Friday =" + (int)Days.Friday);
            Console.WriteLine("Sunday =" + (int)Days.Sunday);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Week sbj=new Week();
            sbj.number_Of_Days();
            Console.ReadLine();
        }
    }
}
