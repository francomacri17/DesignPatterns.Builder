using DesignPatterns.Builder;

class Program
{
    static void Main(string[] args)
    {
        var director = new VehicleDirector();

        // Build a car
        var carBuilder = new CarBuilder();
        var car = director.Construct(carBuilder);
        car.Show();

        // Build a motorcycle
        var motorcycleBuilder = new MotorcycleBuilder();
        var motorcycle = director.Construct(motorcycleBuilder);
        motorcycle.Show();
    }
}