using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class Cessna : Flyers, IFlyingVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Auto";
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; } = 5.0;
        public double MaxLandSpeed { get; set; } = 15;
        public double MaxAirSpeed { get; set; } = 150;

        public string Drive()
        {
            return "Taxiing";
        }

        public string Fly()
        {
            return "Flying!";
        }

        public string Start()
        {
            return "Engine Started";
        }

        public string Stop()
        {
            return "Engine Stopped";
        }
    }
}