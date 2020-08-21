using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LIV_Andreja_Kolesar
{
    abstract class MotorVehicle
    {
        
        internal List<string> colors = new List<string>() { "red", "green", "blue", "white", "orange" };

        internal double vehicleVolume { get; set; }
        internal int weight { get; set; }
        internal string category { get; set; }
        internal string engineType { get; set; }
        private string _color;
        internal string color {
            get
            {
                int n = Program.random.Next(0, 5);
                return colors[n];
            }
            set
            {
                _color = value;
            }
        }
        internal int engineNumber { get; set; }

        internal abstract void Start();
        internal abstract void Stop();

    }
}
