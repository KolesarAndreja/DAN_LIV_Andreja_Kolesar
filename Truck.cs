using System;

namespace DAN_LIV_Andreja_Kolesar
{
    class Truck : MotorVehicle
    {

        internal double loadCapacity { get; set; }
        internal double height { get; set; }
        internal int numberOfSeats { get; set; }

        internal override void Start()
        {
            Console.WriteLine("Truck has started");
        }

        internal override void Stop()
        {
            Console.WriteLine("Truck has stopped");
        }

        internal void Load()
        {
            Console.WriteLine("Loading...");
        }

        internal void Unload()
        {
            Console.WriteLine("Unloading...");
        }
    }
}
