using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _5_Student_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "jayesh","swanand","samkash","Hari","riyan" };
            string[] name1 = name;
            
            for (int i = 0; i < name1.Length; i++)
            {
                Console.Write(name1[i]+"\t");
            }Console.ReadLine();
        }
    }
}
