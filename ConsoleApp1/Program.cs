using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(String[] args)
        {
            Random rnd = new Random();
            Truck truck = new Truck();
            PassCar PassCar = new PassCar();
            Car car = new Car();

            int fr = rnd.Next(0, 2);
            int typeid = rnd.Next(0, 2);
            PassCar.Passcount = rnd.Next(1, 6);
            Transport[] transports = new Transport[2];
            transports[0] = PassCar;
            transports[1] = truck;
            if (fr == 0)
            {
                truck.Freight = "Wood";

            }
            else if (fr == 1)
            {
                truck.Freight = "Bricks";

            }
            else if (fr == 2)
            {
                truck.Freight = "Copper_Wire";

            }
            if (typeid == 0 || typeid < 0)
            {
                car.Cartype1 = "Pass.car";

            }
            else if (typeid == 1||typeid>1)
            {
                car.Cartype1 = "Truck";
            }


            transports[0].Print();
            //Console.WriteLine("typeid:" + typeid);//
            if (typeid == 0)
            {
                Console.WriteLine("CarType:" + car.Cartype1);
                Console.WriteLine("Pass.count:" + (transports[0] as PassCar).Passcount);
            }
            else if (typeid == 1)
            {
                Console.WriteLine("CarType:" + car.Cartype1);
                Console.WriteLine("Freight:" + (transports[1] as Truck).Freight););
            }
            Console.ReadKey();
        
        }
    } 
}
