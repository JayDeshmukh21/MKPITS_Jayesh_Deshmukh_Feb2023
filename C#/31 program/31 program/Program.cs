using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the character");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine(ch + "is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + "is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + "is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + "is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch +  "is a Vowel");
                    break;

                default:
                    Console.WriteLine(ch + "is a Consonant");
                    break;

            }
            Console.ReadLine();


            }
        }
}
