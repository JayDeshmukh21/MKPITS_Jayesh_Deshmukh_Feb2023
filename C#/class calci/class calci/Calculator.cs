using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_calci
{
    internal class Calculator
    {
        internal class calculator
        {
            double prev_no = 0;
            char op;
            double result = 0;

            public char Plus_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '+';
                return op;
            }

            public char Minus_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '-';
                return op;
            }

            public char Multiply_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '*';
                return op;
            }

            public char Divide_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '/';
                return op;
            }

            public char Modulus_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '%';
                return op;
            }

            public char Power_Click(double prev_no)
            {
                this.prev_no = prev_no;
                op = '^';
                return op;
            }
            public double calculateResult(double num)
            {
                switch (op)
                {
                    case '+':
                        result = prev_no + num;
                        break;

                    case '-':
                        result = prev_no - num;
                        break;

                    case '*':
                        result = prev_no * num;
                        break;

                    case '/':
                        result = prev_no / num;
                        break;

                    

                    
                }
                return result;
            }

        }
    }

}
