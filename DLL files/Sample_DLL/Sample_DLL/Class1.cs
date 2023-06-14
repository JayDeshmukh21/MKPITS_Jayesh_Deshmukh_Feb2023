using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_DLL
{
    public class Class1
    {
        public string addition (int a, int b)
        {
            int res = a + b;
            return "addition is "+res.ToString();
        }
        public string substraction (int a, int b)
        {
            int res = a - b;
            return "Substraction is " +res.ToString();
        }
        public string Division (int a, int b)
        {
            float  res = a / b;
            return "Division is " + res.ToString();
        }
        public string Multiply (int a, int b)
        {
            int res = a * b;
            return "Multiplication is " + res.ToString();
        }
    }
}
