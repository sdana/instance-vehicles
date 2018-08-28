public interface IWaterVehicle
    {
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        string Start();
        string Stop();
        string Drive();
    }