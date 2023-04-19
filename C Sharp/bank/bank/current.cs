using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class current:Account
    {
        public override int deposit(int amt)
        {
            bal = bal + amt;
            return bal;
        }
    }
}
