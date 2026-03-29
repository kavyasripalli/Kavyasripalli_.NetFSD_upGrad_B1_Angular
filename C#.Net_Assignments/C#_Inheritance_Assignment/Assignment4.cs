using System;

class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }

    public void StartVehicle()
    {
        Console.WriteLine("Vehicle started");
    }
}

// car
class Car : Vehicle
{
    public string FuelType { get; set; }
}

// bike
class Bike : Vehicle
{
}

// electric
sealed class ElectricCar : Car
{
}

// class Tesla : ElectricCar
// {
// }
//Compile-time error

class Assignment4
{
    public static void Run()
    {
        Car c = new Car { VehicleNumber = "AP01", Brand = "Toyota", FuelType = "Petrol" };
        c.StartVehicle();

        Bike b = new Bike { VehicleNumber = "AP02", Brand = "Yamaha" };
        b.StartVehicle();

        ElectricCar e = new ElectricCar { VehicleNumber = "AP03", Brand = "Tesla", FuelType = "Electric" };
        e.StartVehicle();
    }
}