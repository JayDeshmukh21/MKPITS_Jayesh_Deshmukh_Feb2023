using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_1
{
    class Account
    {
        public int bal = 1000;
        public virtual int deposit(int amt)
        {
            return bal;
        }

    }
    

    

    internal class account
    {
    }

}
