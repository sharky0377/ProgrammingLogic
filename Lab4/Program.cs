namespace Lab4;

using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details: ");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Problem 1: Add a Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Add a Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles. ");
    }

    // Problem 3: Add a Method with a Return Value
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Problem 4: Add a Method that Updates a Field
    public void Repaint(string newColor)
    {
        this.color = newColor;
        Console.WriteLine("The car has been repainted to " + newColor + ".");

    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display();
        Console.WriteLine();


        // Problem 1: Call Start()
        myCar.Start();
        Console.WriteLine();


        // Problem 2: Call Drive (int miles)
        myCar.Drive(50);
        Console.WriteLine();


        // Problem 3: Call GetDescription() and print result
        string carDescription = myCar.GetDescription();
        Console.WriteLine("Car Description: " + carDescription);
        Console.WriteLine();


        // Problem 4: Call Repaint() and confirm update
        Console.WriteLine("Original color before repaint: " + myCar.color);
        myCar.Repaint("Red");
        Console.WriteLine("New color after repaaint: " + myCar.color);
        Console.WriteLine();
    }
}

