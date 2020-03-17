using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    abstract class Vehicle
    {
        public string fuelCapacity { get; set; }
        public VehicleColors Color { get; set; }
        public int passengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine($"The {Color} vehicle is now fueled");
        }

    }
        enum VehicleColors
        {
            red,
            yellow,
            green,
            blue,
            purple,
            gray,
            black,
            white
        }
}
