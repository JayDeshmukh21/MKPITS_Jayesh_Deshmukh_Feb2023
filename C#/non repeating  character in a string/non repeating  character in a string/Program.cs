using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_repeating__character_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "shantshanu";
            char result = '\0'; // null character
            int ind = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isRepeated = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (!isRepeated)
                {
                    result = input[i];
                    ind = i;
                    break;
                }
            }

            if (result != '\0')
            {
                Console.WriteLine("The first non-repeating character in the string is: {0}", result);
                Console.WriteLine("The first non-repeating character index in the string is: {0}", ind);
            }
            else
            {
                Console.WriteLine("There are no non-repeating characters in the string.");
            }

        }
    }
}
