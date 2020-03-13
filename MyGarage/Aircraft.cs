using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft
    {
        public string fuelCapacity { get; set; }
        public string color { get; set; }
        public int passengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("The aircraft is now fueled");
        }

        public void Fly()
        {
            Console.WriteLine("Wooooosh");
        }

        public void Land()
        {
            Console.WriteLine("Now landing. Brace yourselves.");
        }

    }
}
