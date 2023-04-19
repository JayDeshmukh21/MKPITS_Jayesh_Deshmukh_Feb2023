using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter character");
            ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') 
            {
                Console.WriteLine(ch + " is a Vowel");
            }
            else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') 
            {
                Console.WriteLine(ch  + "is a Vowel");
            }
            else 
            { 
                  Console.WriteLine(ch + "is a Consonant");
            }
            Console.ReadLine();
        }
    }
}
