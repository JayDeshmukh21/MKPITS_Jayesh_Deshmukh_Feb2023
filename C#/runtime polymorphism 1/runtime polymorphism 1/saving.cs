using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_1
{
    class Saving : Account
    {
        int interest = 500;
        public override int deposit(int amt)
        {
            bal = bal + amt + interest;
            return bal; 
        }

    }
   
}
