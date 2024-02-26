namespace DesignPatterns.Builder;

// Director class defines the order in which to execute the building steps
public class VehicleDirector
{
    public Vehicle Construct(IVehicleBuilder builder)
    {
        builder.BuildFrame();
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
        return builder.GetVehicle();
    }
}