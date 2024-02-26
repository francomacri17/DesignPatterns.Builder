namespace DesignPatterns.Builder;

// Concrete builder for Motorcycle
public class MotorcycleBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public MotorcycleBuilder()
    {
        _vehicle = new Vehicle("Motorcycle");
    }

    public void BuildFrame() => _vehicle.AddPart("Frame", "Motorcycle Frame");

    public void BuildEngine() => _vehicle.AddPart("Engine", "500 cc");

    public void BuildWheels() => _vehicle.AddPart("Wheels", "2");

    public void BuildDoors() => _vehicle.AddPart("Doors", "0"); // Motorcycles don't have doors

    public Vehicle GetVehicle() => _vehicle;
}