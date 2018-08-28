using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class Amphicar : Drivers, IRoadVehicle, IWaterVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 3;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.7;
        public double MaxLandSpeed { get; set; } = 120;
        public double MaxWaterSpeed { get; set; } = 25;

        public string Drive()
        {
            return "Crusin' ";
        }

        public string Start()
        {
            return "Starting Engine";
        }

        public string Stop()
        {
            return "Killing Engine";
        }
    }
}