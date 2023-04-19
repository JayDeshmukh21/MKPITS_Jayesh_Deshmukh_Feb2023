using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class calculate
    {
        int num1, num2;
        int result = 0;
        char op;
        public int calculateresult(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;

            }
            return result;


        }
    }
    internal class Calculate
    {
    }
}
