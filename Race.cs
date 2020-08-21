using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace DAN_LIV_Andreja_Kolesar
{
    class Race
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        Queue<Car> q = new Queue<Car>();

        //change light on semaphore for every two seconds
        public void SemaphoreLight()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            while(s.ElapsedMilliseconds< 30000)
            {
                if (s.ElapsedMilliseconds % 2000 == 0)
                {
                    autoResetEvent.Set();
                }
                else
                {
                    autoResetEvent.Reset();
                }
            }
        }
        public void StartingPoint()
        {
            Console.WriteLine("Race starts...");
        }

        public void RaceMethod(Car car)
        {
            Stopwatch firstPart = new Stopwatch();
            firstPart.Start();
            while (firstPart.ElapsedMilliseconds < 10000)
            {
                if (car.currentVolume > 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Car " + car.registrationNumber + " is racing");
                    car.currentVolume = car.currentVolume - car.consumption;
                }
                else
                {
                    Console.WriteLine("Car" + car.registrationNumber + " has stopped due to lack of fuel");
                    return;
                }
            }
            firstPart.Stop();
            Stopwatch secondPart = new Stopwatch();

            Console.WriteLine("Car " + car.registrationNumber + "is at traffic light...");
            autoResetEvent.WaitOne();
            secondPart.Start();
            Console.WriteLine("Car " + car.registrationNumber + " has passed traffic light");
            while (secondPart.ElapsedMilliseconds < 3000)
            {
                if (car.currentVolume > 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Car " + car.registrationNumber + " is racing");
                    car.currentVolume = car.currentVolume - car.consumption;
                }
                else
                {
                    Console.WriteLine("Car" + car.registrationNumber + " has stopped due to lack of fuel");
                    return;
                }

            }
            secondPart.Stop();

            if (car.currentVolume < 15)
            {
                Console.WriteLine("Car " + car.registrationNumber + "has stopped to fill fuel");
                q.Enqueue(car);
                while(q.Peek() != car)
                {
                    Thread.Sleep(0);
                }
                //fill fuel
                Thread.Sleep(700);
                car.currentVolume = car.tankVolume;
                q.Dequeue();
                Console.WriteLine("Car " + car.registrationNumber + " has filled fuel");
            }

            Stopwatch thirdPart = new Stopwatch();
            thirdPart.Start();
            while (thirdPart.ElapsedMilliseconds < 7000)
            {
                if (car.currentVolume > 0)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Car " + car.registrationNumber + " is racing");
                    car.currentVolume = car.currentVolume - car.consumption;
                }
                else
                {
                    Console.WriteLine("Car" + car.registrationNumber + " has stopped due to lack of fuel");
                    return;
                }
            }
            Console.WriteLine("Car " + car.registrationNumber + "," + car.producer + " " + car.color + " finished race");
        }
       
    }
}
