
namespace vehicles
{
public interface IRoadVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxLandSpeed { get; set; }
        string Start();
        string Stop();
        string Drive();

    }
}