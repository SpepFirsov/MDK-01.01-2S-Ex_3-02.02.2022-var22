using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : Transport
    {
        private bool _is_private;

        private string Cartype;

        public string Cartype1 { get => Cartype; set => Cartype = value; }
        public bool Is_private { get => _is_private; set => _is_private = value; }

        public override void Type()
        {

            Console.WriteLine("Type");

        }
        public override void Private()
        {
            Is_private = true;
        }        
        

        public override void Ground()
        {
        }
        public virtual void Print()
        {
        }
    }
}
