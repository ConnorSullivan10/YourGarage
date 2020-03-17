using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Watercraft : Vehicle
    {
        public int TotalHorsepower { get; set; } = 0;
        public string Length { get; set; } = "";
        public Watercraft(int totalHorsePower, string length)
        {
            TotalHorsepower = totalHorsePower;
            Length = length;
        }
        public void Drive()
        {
            Console.WriteLine($"Pew pewwwwwwwwww. That {TotalHorsepower}hp boat is pretty fast and looks bigger than it's actual size of {Length} ");
        }

    }
}
