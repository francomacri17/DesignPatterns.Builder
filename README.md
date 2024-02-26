# Vehicle Builder Pattern Example in C#

This repository contains an implementation of the Builder design pattern in C#. The Builder pattern is used to construct a complex object step by step and the final step will return the object. The process of constructing an object should be generic so that it can be used to create different types of objects.

## Overview

The Builder pattern is useful when an object needs to be created with many possible configurations. Instead of creating multiple constructors, which can get complex with many parameters, the Builder pattern uses another object, a builder, to construct the object step by step.

This example demonstrates building two types of vehicles: a Car and a Motorcycle, showcasing how the Builder pattern can encapsulate the construction logic for objects with different configurations.

## Structure

The implementation includes the following components:

- `Vehicle`: The product class, which represents the object being built.
- `IVehicleBuilder`: The builder interface with methods to build parts of the product.
- `CarBuilder` and `MotorcycleBuilder`: Concrete builder classes that implement the `IVehicleBuilder` interface to construct specific types of vehicles.
- `VehicleDirector`: The director class, which takes a builder object and executes the steps to construct and return the finished product.

## Usage

To use this pattern, create an instance of the `VehicleDirector` class and pass a concrete builder instance to its `Construct` method. The director will use the builder to construct the vehicle step by step, and then return the completed vehicle.

Example:

```csharp
var director = new VehicleDirector();

IVehicleBuilder carBuilder = new CarBuilder();
Vehicle car = director.Construct(carBuilder);
car.Show();

IVehicleBuilder motorcycleBuilder = new MotorcycleBuilder();
Vehicle motorcycle = director.Construct(motorcycleBuilder);
motorcycle.Show();
```

This will construct a Car and a Motorcycle, each with their specific configurations, and then display their parts.

## Contributing

Feel free to fork this repository and submit pull requests to contribute to this example. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is open-source and available under the MIT License. See the LICENSE file for more details.
