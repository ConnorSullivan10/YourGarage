using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car
    {
        public string fuelCapacity { get; set; }
        public string color { get; set; }
        public int passengerOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("The car is now fueled");
        }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }

        public void Brake()
        {
            Console.WriteLine("Skkrrrrr. Slowing down");
        }


    }
}
