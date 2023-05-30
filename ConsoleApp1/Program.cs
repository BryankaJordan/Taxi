using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi Taxi = new Taxi();

            Taxi.Name = "Usep";
            Taxi.Duty = true;
            Taxi.Passanger = 5;

            Taxi.TaxiInfo();
            Taxi.PickUpPassanger();
            Taxi.DropOffPassanger();

            Console.ReadKey();
        }

    }
   
}
