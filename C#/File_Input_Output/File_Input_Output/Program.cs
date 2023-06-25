using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.txt";
            string data = "This is some sample data.";

            // Write data to a file
            File.WriteAllText(filePath, data);
            Console.WriteLine("Data written to file: " + filePath);

            // Read data from the file
            string readData = File.ReadAllText(filePath);
            Console.WriteLine("Data read from file: " + readData);
            Console.ReadLine();
        }
    }
}
