using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklibrary1
{
   
        public class Class1
        {
            int balance = 1000;
            public string deposit(int amount)
            {
                balance = balance + amount;
                return "Balance is " + balance.ToString();
            }
            public string withdraw(int amount)
            {
                balance = balance - amount;
                return "Balance is " + balance.ToString();
            }
        }
    }

