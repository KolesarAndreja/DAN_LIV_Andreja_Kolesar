using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LIV_Andreja_Kolesar
{
    class Car : MotorVehicle
    {
        internal string registrationNumber { get; set; }
        internal int numberOfDoors { get; set; }
        internal int tankVolume { get; set; }
        internal string transmissionType { get; set; }
        internal string producer { get; set;}
        internal int licenseNumber { get; set; }
        internal int consumption
        {
            get
            {
                
                int n = Program.random.Next(2, 5);
                return n;
            }
        }
        internal int currentVolume;

        #region Methods
        internal void Repaint(string newColor)
        {
            this.color = newColor;
            licenseNumber = Program.random.Next(10000, 100000);
        }
        internal void Ready()
        {
            Console.WriteLine("Car " + this.color + " " + this.producer + " with reg number " + this.registrationNumber + " is ready");
        }

        internal override void Start()
        {
            Console.WriteLine("Car has started");
        }

        internal override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
        #endregion
    }
}
