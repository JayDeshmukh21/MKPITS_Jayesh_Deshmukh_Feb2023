using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel__inheritance
{
    class phone
    {
        public string brand;
        public string model;

        public void makecall(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public void sendtext()
        {
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Model : " + model);
        }
        class camera
        {
            int
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
