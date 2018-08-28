using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public class SeaPlane: Flyers, IFlyingVehicle, IWaterVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 6;
        public string TransmissionType { get; set; } = "Auto";
        public bool Winged { get; set; } = true;
        public double EngineVolume { get; set; } = 5;
        public double MaxLandSpeed { get; set; } = 10;
        public double MaxAirSpeed { get; set; } = 150;
        public double MaxWaterSpeed { get; set; } = 1.5;

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