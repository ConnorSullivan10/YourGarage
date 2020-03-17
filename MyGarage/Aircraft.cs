using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Aircraft : Vehicle
    {
        public string PlaneSerial { get; set; } = "";
        public int NumOfPropellers { get; set; } = 2;

        public Aircraft(string planeSerial, int numOfPropellers)
        {
            this.PlaneSerial = planeSerial;
            this.NumOfPropellers = numOfPropellers;
        }
        public void Fly()
        {
            Console.WriteLine($" All {NumOfPropellers} propellers on Aircraft No. {PlaneSerial} screamed Wooooosh as it flew away");
        }

        public void Land()
        {
            Console.WriteLine($" Aircraft {PlaneSerial} is Now landing. Brace yourselves.");
        }
    }
}
