using System;

// 1. Define your custom exception class
public class UnderAgeException : Exception
{
    public UnderAgeException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // 2. Business logic: Check the age
            if (age < 18)
            {
                // 3. Manually throw the exception
                throw new UnderAgeException("Access Denied: You must be at least 18 years old.");
            }

            Console.WriteLine("Access Granted! Welcome to the system.");
        }
        catch (UnderAgeException ex)
        {
            // Catching our specific custom exception
            Console.WriteLine($"Custom Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number for age.");
        }
        
        Console.WriteLine("Program execution ended.");
    }
}