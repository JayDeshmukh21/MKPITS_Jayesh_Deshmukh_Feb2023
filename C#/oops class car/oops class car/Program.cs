using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_class_car
{
    class car
    {
        public string name;
        public string color;
        public int price;
        //public int model_no;

        public void getdata(string n,string clr,int p/*,int m*/)
        {
            name = n;
            color=clr; 
            price=p; 
            //model_no = m;

        }
        public void displaydata()
        {
            Console.WriteLine("name =" + name);
            Console.WriteLine("color =" + color);
            Console.WriteLine("price ="+price);
            //Console.WriteLine("Model number ="+model_no);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car vehical= new car();
            Console.WriteLine("Enter car name : ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter color :");
            string color=Console.ReadLine();
            Console.WriteLine("Enter Price :");
            int price=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter model number :");
            //int model_no=Convert.ToInt32(Console.ReadLine());

            vehical.getdata(name,color,price/*,model_no*/);
            vehical.displaydata();
            Console.ReadLine();
        }
    }
}
