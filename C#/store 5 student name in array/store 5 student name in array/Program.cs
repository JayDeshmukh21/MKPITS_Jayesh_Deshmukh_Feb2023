using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_5_student_name_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "yasmin", "anjali", "monali", "sahil", "tanmay", "jayesh" };
            string[] name1 = (string[])name.Clone();
            for (int i = 0; i < name1.Length; i++)
            {
                Console.WriteLine(name1[i] + "\t");
            }
        }
    }
}
