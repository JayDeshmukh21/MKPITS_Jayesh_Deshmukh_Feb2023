using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops.class__product_
{
    class product
    {
        public string product_type;
        public int product_item;
        public string product_size;
        public string product_company;

        public void getdata(string name, int num,string size)
        {
            product_type = name;
            product_item = num;
            product_size = size;
            product_company = "Hindustan Unilever Limited";
        }
        public void displaydata()
        {
            Console.WriteLine("product type- "+ product_type);
            Console.WriteLine("product item -" +product_item);
            Console.WriteLine("size -"+ product_size);
            Console.WriteLine("manufacturing company -" +product_company);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product jp1=new product();
            
            Console.Write("Enter product type: ");
            string type=Console.ReadLine();
            Console.Write("Enter item number : ");
            int item=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size :");
                string size=Console.ReadLine();
            
            jp1.getdata(type,item,size);
            jp1.displaydata();
            Console.ReadLine();
        }
    }
}
