using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Perimeter
    {
        public enum shape
        {
            circle,square
        }
        public void peri(int val ,shape s1)
        {
            if(s1==0)
            {
                float cir = 2 * 3.14f * val;
                Console.WriteLine("circumfarance of circle = " +cir);
            }
            else
            {
                int perimater = 4 * val;
                Console.WriteLine("perimeter of square = " + perimater);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Perimeter p1= new Perimeter();
            p1.peri(8,Perimeter.shape.circle);
            p1.peri(8, Perimeter.shape.square);
            Console.ReadLine();
        }
    }
}
