using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace array_of_interger_as_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3 };
            calculate(arr);


        }
        static void calculate(int[] arr1)
        {


            int result=0;
            for (int c = 0; c < arr1.Length; c++)
            { 
            result= result + arr1[c];
            }
           Console.WriteLine("addition "+ result);
           
        }
       
    }
}
