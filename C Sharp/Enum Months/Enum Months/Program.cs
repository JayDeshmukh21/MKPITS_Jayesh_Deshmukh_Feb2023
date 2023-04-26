using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Months
{
    class Months
    {
       public enum Calender
        {
            jan , feb, mar, apr,dec
        }
        public void display()
        {
            Console.WriteLine("January = " +(int)Calender.jan);
            Console.WriteLine("february = " + (int)Calender.feb);
            Console.WriteLine("march = " + (int)Calender.mar);
            Console.WriteLine("april = " + (int)Calender.apr);
            Console.WriteLine("december = " + (int)Calender.dec);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Months jsy = new Months();
            jsy.display();
            Console.ReadLine();
        }
    }
}
