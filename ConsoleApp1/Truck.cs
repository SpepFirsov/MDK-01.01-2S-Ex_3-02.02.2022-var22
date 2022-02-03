using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Truck : Car
    {
        private string freight;
        public string Freight { get => freight; set => freight = value; }

        public override void Print()
        {
            Console.WriteLine("Freight:");
        }
        public override void Ground()
        {
            Console.WriteLine("Transport is on ground");
        }
        public override void Type()
        {
            Console.WriteLine("Type - truck");
        }



    }
}
