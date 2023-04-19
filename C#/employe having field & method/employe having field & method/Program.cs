using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employe_having_field___method
{
    class employee
    {
        
         int id ;
         string  name ;
         int number;
         string  designation ;

        public void getdata()
        {
            id = 123;
            name = "Zoya";
            number = 1234567890;
            designation = "Manager";
        
        }

        public void displaydata()
        {
            Console.WriteLine("id : " +  id);
            Console.WriteLine("name : " + name);
            Console.WriteLine("number : " +  number);   
            Console.WriteLine("designation : " + designation);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee empl = new employee();
            empl.getdata();
            empl.displaydata();
        }
    }
}
