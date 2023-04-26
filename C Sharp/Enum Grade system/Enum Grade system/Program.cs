using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Grade_system
{
    class Grade
    {
        public enum grade
        {
            A,B,C,D
        }
        public void display(int A,int B,int C,int D)
        {
            Console.WriteLine("Grade A marks =" + A);
            Console.WriteLine("Grade B marks =" + B);
            Console.WriteLine("Grade C marks =" + C);
            Console.WriteLine("Grade D marks =" + D);
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade smpl= new Grade();
            smpl.display(95,80,70,45);
            Console.ReadLine();
        }
    }
}
