using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class Canoe : IWaterVehicle
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 0;
        public double MaxWaterSpeed { get; set; } = 15;

        public string Drive()
        {
           return "Paddling";
        }

        public string Start()
        {
           return "Pushing Off";
        }

        public string Stop()
        {
           return "Pulling to shore";
        }
    }
}