using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_is_a_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc;
            Console.WriteLine("Enter  a string");
            abc= Console.ReadLine();
            palindrome(abc);
            Console.ReadLine();

        }
        static void palindrome(string abc)
        {
            char[] chars = abc.ToCharArray();
            string reversedString = String.Empty;
            for(int i = chars.Length-1; i >= 0 ; i--) 
            {
            
            reversedString += chars[i];
            }
            if (reversedString == abc)
            {
                Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", abc,reversedString);
            }
            else 
            {
                Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", abc, reversedString);
            }
        }
    }
}
