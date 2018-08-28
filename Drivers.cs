namespace vehicles
{
    public class Drivers
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public string Drive()
        {
            return "heading down the road!";
        }

        public string Start()
        {
            return "turning Key";
        }

        public string Stop()
        {
            return "engines off";
        }
    }
}