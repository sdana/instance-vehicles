using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class Motorcycle : Drivers, IRoadVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1000;
        public double MaxLandSpeed { get; set; } = 180;

        public string Drive()
        {
            return "Riding!";
        }

        public string Start()
        {
            return "Kick-starting Engine";
        }

        public string Stop()
        {
            return "Killing Engine";
        }
    }
}