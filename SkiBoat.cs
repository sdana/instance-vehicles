using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class SkiBoat : IWaterVehicle
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 7;
        public string TransmissionType { get; set; } = "Auto";
        public double EngineVolume { get; set; } = 250;
        public double MaxWaterSpeed { get; set; } = 80;

        public string Drive()
        {
           return "Cruisin'";
        }

        public string Start()
        {
          return "Starting Engine";
        }

        public string Stop()
        {
          return "Docking";
        }
    }
}