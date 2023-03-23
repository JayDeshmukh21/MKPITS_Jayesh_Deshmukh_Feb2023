using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_accept_char_frm_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chr;
            Console.WriteLine("enter character");
            chr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("character entered : " +chr);
            Console.ReadLine();
        }
    }
}
