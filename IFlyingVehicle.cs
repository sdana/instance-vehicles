public interface IFlyingVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    bool Winged { get; set; }
    double EngineVolume { get; set; }
    double MaxLandSpeed { get; set; }
    double MaxAirSpeed { get; set; }
    string Start();
    string Stop();
    string Drive();
    string Fly();
}