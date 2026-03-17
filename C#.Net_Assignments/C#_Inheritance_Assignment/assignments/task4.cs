using System;
using System.Collections.Generic;
using System.Text;


public class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }

    public void StartVehicle()
    {
        Console.WriteLine("Vehicle started.");
    }
}

public class Car : Vehicle
{
    public string FuelType { get; set; }
}

public sealed class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public void ChargeBattery()
    {
        Console.WriteLine("Charging battery...");
    }
}

class task4
{
    static void Main()
    {
        ElectricCar car = new ElectricCar();

        car.VehicleNumber = "AP09AB1234";
        car.Brand = "Tesla";
        car.FuelType = "Electric";
        car.BatteryCapacity = 75;

        car.StartVehicle();
        car.ChargeBattery();
    }
}