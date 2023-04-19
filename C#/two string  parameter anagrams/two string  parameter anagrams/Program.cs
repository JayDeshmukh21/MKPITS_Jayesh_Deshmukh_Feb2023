using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_string__parameter_anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string 1");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter string 2");
            string str2 = Console.ReadLine();
            bool i = anagram(str1, str2);
            Console.WriteLine(i);

        }
        static bool anagram(string str1,string str2)
        {
            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string val1 = new string(arr1);
            string val2 = new string(arr2);
            Console.WriteLine(val1); 
            Console.WriteLine(val2);
            if (val1 == val2) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
