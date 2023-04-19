using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract void deposit(int amt);
        public string showbalance()
        {
            return "bal is " + bal;
        }
    }
    class saving : Account
    {
        int interest = 500;
    }
        static void Main(string[] args)
        {

        }
    }
}
