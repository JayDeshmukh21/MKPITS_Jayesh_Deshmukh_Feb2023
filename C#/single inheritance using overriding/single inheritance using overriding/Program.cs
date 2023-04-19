using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_using_overriding
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
            Console.WriteLine("name " + name);
            Console.WriteLine("ADDRESS " + address);
        }
    }

    class customer : person 
    {
        public int custid;

        public void getdata(int custid, string name,string address) 
        {
            this.custid = custid;
            getdata(name, address);
        
        }

        public void display()
        { 
         base.display();
            Console.WriteLine("custid " + custid);
        
        }
    
    
    
    }
        

        

    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getdata(123, "yasmin", "nagpur");
            cust.display();
            Console.ReadKey();

        }
    }
}
