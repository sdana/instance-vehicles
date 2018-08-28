using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class JetSki : IWaterVehicle
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 0;
        public string TransmissionType { get; set; } = "Auto";
        public double EngineVolume { get; set; } = 125;
        public double MaxWaterSpeed { get; set; } = 60;

        public string Drive()
        {
           return "Cruisin'";
        }

        public string Start()
        {
           return "StartingEngine";
        }

        public string Stop()
        {
           return "Docking";
        }
    }
}