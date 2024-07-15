


/*Write a program to create a class called Car with Model, Year of making details. 
  
Read the Car details from the User and store into a file.*/

using System;
using System.IO;

class CarModel
{
    public string Model { get; set; }
    public int YearOfMaking { get; set; }

    public CarModel(string model, int yearOfMaking)
    {
        Model = model;
        YearOfMaking = yearOfMaking;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Year of Making: {YearOfMaking}";
    }
}

class Exercise3
{
    static void Main()
    {
        Console.Write("Enter the car model: ");
        string model = Console.ReadLine();

        Console.Write("Enter the year of making: ");
        int yearOfMaking;
        while (!int.TryParse(Console.ReadLine(), out yearOfMaking) || yearOfMaking <= 0)
        {
            Console.Write("Please enter a valid year: ");
        }

        CarModel car = new CarModel(model, yearOfMaking);

        string filePath = "D:/CarDetails.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(car.ToString());
            }
            Console.WriteLine("Car details saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while saving car details: " + ex.Message);
        }
    }
}
