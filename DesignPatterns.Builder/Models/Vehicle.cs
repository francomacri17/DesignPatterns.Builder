namespace DesignPatterns.Builder;

    // Product class defines the type of object to be built
    public class Vehicle
    {
        public string VehicleType { get; set; }
        public Dictionary<string, string> Parts { get; private set; } = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            VehicleType = vehicleType;
        }

        public void AddPart(string key, string value)
        {
            Parts.Add(key, value);
        }

        public void Show()
        {
            Console.WriteLine($"\nVehicle Type: {VehicleType}");
            foreach (var part in Parts)
            {
                Console.WriteLine($"{part.Key}: {part.Value}");
            }
        }
    }