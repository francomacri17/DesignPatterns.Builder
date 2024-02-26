namespace DesignPatterns.Builder;

// Builder interface with steps to build the parts of the product
public interface IVehicleBuilder
{
    void BuildFrame();
    void BuildEngine();
    void BuildWheels();
    void BuildDoors();
    Vehicle GetVehicle(); // Ensure all builders can return a vehicle
}