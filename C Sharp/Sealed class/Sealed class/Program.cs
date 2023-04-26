using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{
    sealed class employee
    {
        public void showdata()
        {
            Console.WriteLine("hello jay"); []
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.showdata();
            Console.ReadLine();
        }
    }
}
