using System;

namespace search_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isfound = false;
            string[] arr = new string[] { "Apple", "watermelon", "mango", "greaps", "gauva", "coconut" };
            Console.WriteLine("enter fruit name to search");
            string name = Convert.ToString(Console.ReadLine());

            for (int count = 0; count < arr.Length; count++)
            {
                if (arr[count] == name)
                {
                    isfound = true;
                    break;
                }

            }
            if (isfound == true)
            {
                Console.WriteLine(name + " is Available");
            }
            else
            {
                Console.WriteLine("entered fruit not Available");
            }
            Console.ReadLine();
        }
    }
}
