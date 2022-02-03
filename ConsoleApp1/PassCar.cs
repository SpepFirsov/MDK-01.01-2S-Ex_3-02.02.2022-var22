using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PassCar : Car
    {
        private int passcount;

        public int Passcount { get => passcount; set => passcount = value; }

        public PassCar()
        {
        }

        public override void Print()
        {
            Console.WriteLine("Pass.count:" + passcount);
        }
        public override void Ground()
        {
            Console.WriteLine("is on ground");
        }
        public override void Type()
        {
            Console.WriteLine("Type - pass.car");
        }
    }
}
