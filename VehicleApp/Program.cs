using System;
using System.Collections;
using System.Collections.Generic;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicCollection<Vehicle> vehicles = new DynamicCollection<Vehicle>();
            vehicles.Add(new Car("Toyota", "Corolla", 120, 4, true));
            vehicles.Add(new Motorcycle("Harley-Davidson", "Softail", 100, 0, 1200));
            vehicles.Add(new Truck("Ford", "F-150", 200, 4, 6));
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($" Brand: {vehicle.Brand}\n Model: {vehicle.Model}\n Horse Power: {vehicle.HorsePower}\n Doors: {vehicle.Doors}");
                Console.WriteLine();
            }
        }
    }
}