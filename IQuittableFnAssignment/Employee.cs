using System;

public class Employee : IQuittable
{
    public string Name { get; set; }

    public void Quit()
    {
        Console.WriteLine("Employee is quitting the job.");
        // Any additional logic related to quitting can be added here
    }
}