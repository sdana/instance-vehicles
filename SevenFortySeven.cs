using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class SevenFortySeven : Flyers, IFlyingVehicle
    {
        public int Wheels { get; set; } = 18;
        public int Doors { get; set; } = 6;
        public int PassengerCapacity { get; set; } = 300;
        public string TransmissionType { get; set; } = "Auto";
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; } = (10.0*4);
        public double MaxLandSpeed { get; set; } = 20;
        public double MaxAirSpeed { get; set; } = 350;

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