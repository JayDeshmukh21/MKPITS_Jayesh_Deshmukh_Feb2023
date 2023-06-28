using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

class Car : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Car accelerated.");
    }

    public void Brake()
    {
        Console.WriteLine("Car braked.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Model = "Camry";
        myCar.StartEngine();
        myCar.Accelerate();
        myCar.Brake();
        myCar.StopEngine();
        Console.ReadLine();
    }
}
