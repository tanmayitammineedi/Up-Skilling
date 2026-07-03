using System;

class Car
{
    public string Make;

    public string Model;

    public int Year;

    // Default Constructor

    public Car()
    {
        Make = "Toyota";

        Model = "Corolla";

        Year = 2025;
    }

    // Parameterized Constructor

    public Car(
        string make,
        string model,
        int year)
    {
        Make = make;

        Model = model;

        Year = year;
    }

    public void Display()
    {
        Console.WriteLine(
            $"{Make} {Model} {Year}");
    }
}

class Program
{
    static void Main()
    {
        Car c1 = new Car();

        Car c2 = new Car(
            "Honda",
            "City",
            2024);

        c1.Display();

        c2.Display();
    }
}