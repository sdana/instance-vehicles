namespace vehicles
{
    public class Flyers : IFlyingVehicle
    {
        public string Type { get; set;}
        public string Name { get; set;}
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public bool Winged { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public string Drive()
        {
           return "Taxiing";
        }

        public string Fly()
        {
           return "Reached cruising altitude";
        }

        public string Start()
        {
           return "Engines Starting";
        }

        public string Stop()
        {
           return "Landed";
        }
    }
}