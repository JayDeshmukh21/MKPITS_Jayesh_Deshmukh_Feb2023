using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Inheritance_3
{
    class person
    {
        public string name;
        public string address;

        public void getdata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(address);
        }
        class customer : person
        {
            public int custoid;
            public void getdata(int custoid, string name, string address)
            {
                this.custoid = custoid;
                getdata(name, address);
            }
            public void display()
            {
                base.display();
                Console.WriteLine(custoid);
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                customer p1 = new customer();
                p1.getdata(123, "sam", "nagpur");
                p1.display();
                Console.ReadLine();
            }
        }
    }
}
