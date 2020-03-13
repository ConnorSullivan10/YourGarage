using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Watercraft
    {
        public string fuelCapacity { get; set; }
        public string color { get; set; }
        public int passengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("The boat is now fueled");
        }

        public void Drive()
        {
            Console.WriteLine("Pew pewwwwwwwwww");
        }

    }
}
