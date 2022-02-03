using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal abstract class Transport
    {


        abstract public void Type();

        abstract public void Private();

        abstract public void Ground();

       public virtual void Print()
        {
            Console.WriteLine("Transport");
        }
    }
}
