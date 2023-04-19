using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heriarchical_inheritance_vehicle
{

    public class vehicle
    {
        public int modalnumber;
        public int year;
        public int price;
        public void getvehicledata(int modalnumber, int year, int price)
        {
            this.modalnumber = modalnumber;
            this.year = year;
            this.price = price;
        }

        public void displayvehicledata()
        {
            Console.WriteLine("modal number : " + modalnumber);
            Console.WriteLine("year : " + year);
            Console.WriteLine("price : " + price);
        }
    }

        public class car : vehicle 
    {
            public string name;
            public string description;
        
        public void getcardata(string name,string description)
        {
            this.name=name;
            this.description=description;

        }

        public void displaycardata()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("description : " +  description);
        
        }
    
    }

    public class bus:vehicle
    {

        public int cc;

       public void getbusdata(int cc) 
        {
            this.cc = cc;
        }

        public void displaybusdata()
        {
            Console.WriteLine("cc : " +  cc);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            
            c.getvehicledata(1111, 2011, 7000);
            c.getcardata("thar", "asadsdf");
            c.displayvehicledata();
            c.displaycardata();
            Console.WriteLine("---------------------------------");

            bus b = new bus();
            b.getvehicledata(122, 2012, 400);
            b.getbusdata(1200);
            b.displayvehicledata();
            b.displaybusdata();
        }
    }
}
