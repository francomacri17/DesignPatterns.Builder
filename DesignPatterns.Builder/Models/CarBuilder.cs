namespace DesignPatterns.Builder;

// Concrete builder for Car
public class CarBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public CarBuilder()
    {
        _vehicle = new Vehicle("Car");
    }

    public void BuildFrame() => _vehicle.AddPart("Frame", "Car Frame");

    public void BuildEngine() => _vehicle.AddPart("Engine", "2500 cc");

    public void BuildWheels() => _vehicle.AddPart("Wheels", "4");

    public void BuildDoors() => _vehicle.AddPart("Doors", "4");

    public Vehicle GetVehicle() => _vehicle;
}