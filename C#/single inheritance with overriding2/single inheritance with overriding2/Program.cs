using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_with_overriding2
{
    class student
    {
        public string name;
        public string address;
        public int number;
        

        public void getdata(string name,string address,int number)
        {
            this.name = name;
            this.address = address;
            this.number = number; 
            


        }
        public void display()
        {
            Console.WriteLine(" student name : " + name);
            Console.WriteLine("student address : " +  address);
            Console.WriteLine("student number : " + number);


        }
    
    }

    class stud : student
    {

        public int studid;
      
        public int studrno;


        public void getdata(int studid,  int studrno,string name,string address , int number)
        {
            
          
            this.studid = studid;
            
            this.studrno = studrno;
            getdata(name, address , number);


        }

        public void display()
        { 
        base.display();
            Console.WriteLine("student id :" + studid);
          
            Console.WriteLine("student rollno : " + studrno);
        
        
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            stud s1 = new stud();
            s1.getdata(12,1,"yasmin","nagpur",12345);
            s1.display();
            Console.ReadKey();

        }
    }
}
