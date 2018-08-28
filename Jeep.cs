using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class Jeep : Drivers, IRoadVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 4;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 3.5;
        public double MaxLandSpeed { get; set; } = 130;

        public string Drive()
        {
            return "Cruisin' Topless!";
        }

        public string Start()
        {
            return "Keep turning it over...ok engine running";
        }

        public string Stop()
        {
            return "Engine off";
        }
    }
}