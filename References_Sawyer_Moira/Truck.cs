using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace References_Sawyer_Moira
{
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; private set; }
        public object LicencePlate { get; private set; }
        public object Public { get; private set; }

        public Truck(double speedParm, double weightParam, string licenseNum)
        {
            Speed = speedParm;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }


        // prints to console about the truck.
        public void Stringify() 
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicencePlate}!"); 
        }

        public void DecreaseSpeed()
            {
            Speed -= 5;
            }

    }
}
