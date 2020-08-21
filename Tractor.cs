using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LIV_Andreja_Kolesar
{
    class Tractor : MotorVehicle
    {
        internal double tireSize { get; set; }
        internal int wheelbase { get; set; }
        internal string drive { get; set; }

        #region Methods
        internal override void Start()
        {
            Console.WriteLine("Tractor has started");
        }

        internal override void Stop()
        {
            Console.WriteLine("Tractor has stopped");
        }

        #endregion
    }
}
