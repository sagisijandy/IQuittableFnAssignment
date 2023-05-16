using System;


// Define the IQuittable interface with a Quit() method
public interface IQuittable
{
    void Quit();
}


class Program
{
    public static void Main(string[] args)
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = new Employee();

        // Call the Quit() method on the object
        quittableEmployee.Quit();

        // Wait for user input to exit
        Console.ReadLine();
    }
}







