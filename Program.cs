using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAN_LIV_Andreja_Kolesar
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {

            List<MotorVehicle> list = new List<MotorVehicle>(6);
            Queue<MotorVehicle> queue = new Queue<MotorVehicle>(6);
            Stack<MotorVehicle> stack = new Stack<MotorVehicle>(6);

            #region create objects
            MotorVehicle truck1 = new Truck()
            {
                vehicleVolume = 4225.3,
                weight = 1544,
                category = "truck",
                engineType = "A779f",
                engineNumber = 6643,
                loadCapacity = 3229.4,
                height = 3,
                numberOfSeats = 3
            };

            MotorVehicle truck2 = new Truck()
            {
                vehicleVolume = 2256.4,
                weight = 1244,
                category = "truck",
                engineType = "Ai79f",
                engineNumber = 7643,
                loadCapacity = 1149.4,
                height = 2.4,
                numberOfSeats = 2
            };

            MotorVehicle tractor1 = new Tractor()
            {
                vehicleVolume = 2256.4,
                weight = 1244,
                category = "tractor",
                engineType = "Ai79f",
                engineNumber = 6643,
                tireSize = 59.3,
                wheelbase = 5,
                drive = "qqq"
            };

            MotorVehicle tractor2 = new Tractor()
            {
                vehicleVolume = 3316.4,
                weight = 1884,
                category = "tractor",
                engineType = "A44f",
                engineNumber = 66343,
                tireSize = 90.3,
                wheelbase = 4,
                drive = "qqq"
            };

            MotorVehicle car1 = new Car()
            {
                vehicleVolume = 2266.4,
                weight = 1644,
                category = "car",
                engineType = "veew",
                engineNumber = 7813,
                registrationNumber = "1234-DA",
                numberOfDoors = 4,
                tankVolume = 40,
                transmissionType = "1",
                producer = "toyota",
                licenseNumber = 44222,
                currentVolume = 40
            };

            MotorVehicle car2 = new Car()
            {
                vehicleVolume = 2766.4,
                weight = 1634,
                category = "car",
                engineType = "neew",
                engineNumber = 7911,
                registrationNumber = "94842-DA",
                numberOfDoors = 3,
                tankVolume = 45,
                transmissionType = "2",
                producer = "fiat",
                licenseNumber = 6321,
                currentVolume = 45
                
            };


            Car golf = new Car()
            {
                vehicleVolume = 2266.4,
                weight = 1644,
                category = "car",
                color = "orange",
                engineType = "v33w",
                engineNumber = 27313,
                registrationNumber = "d333-03",
                numberOfDoors = 5,
                tankVolume = 60,
                transmissionType = "1",
                producer = "golf",
                licenseNumber = 44222,
                currentVolume = 60
            };
            #endregion

            #region adding vehicles to collections
            list.Add(truck1);
            list.Add(truck2);
            list.Add(tractor1);
            list.Add(tractor2);
            list.Add(car1);
            list.Add(car2);

            queue.Enqueue(truck1);
            queue.Enqueue(truck2);
            queue.Enqueue(tractor1);
            queue.Enqueue(tractor2);
            queue.Enqueue(car1);
            queue.Enqueue(car2);


            stack.Push(truck1);
            stack.Push(truck2);
            stack.Push(tractor1);
            stack.Push(tractor2);
            stack.Push(car1);
            stack.Push(car2);

            #endregion


            for(int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                if (i != 0)
                {
                    Thread.Sleep(1000);
                }
                Console.Clear();
            }

            Car c1 = (Car)list[4];
            Car c2 = (Car)list[5];

            c1.Ready();
            c2.Ready();
            Thread.Sleep(700);
            golf.Ready();
            Race race = new Race();
            Thread t1 = new Thread(()=>race.RaceMethod(c1));
            Thread t2 = new Thread(() => race.RaceMethod(c2));
            Thread t3 = new Thread(() => race.RaceMethod(golf));
            Thread t4 = new Thread(() => race.SemaphoreLight());
            race.StartingPoint();
            t4.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
    }
}

