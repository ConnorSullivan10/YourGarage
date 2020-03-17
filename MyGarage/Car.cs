using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Car : Vehicle
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int YearMake { get; set; } = 0;
        public Car(string make, string model, int yearMake)
        {
            this.Make = make;
            this.Model = model;
            this.YearMake = yearMake;
        }
        public void Drive()
        {
            Console.WriteLine($"Vroom vroom yelled the aggressive {YearMake} {Make} {Model} ");
        }

        public void Brake()
        {
            Console.WriteLine($"The brakes squealed as the {Make} {Model} slowed down");
        }
    }
}
