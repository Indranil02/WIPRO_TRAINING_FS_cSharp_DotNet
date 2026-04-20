using System;

class Program
{
    static void Main()
    {
        // STEP 1: Prompt the user for input
        Console.WriteLine("Enter a number: ");

        try
        {
            // STEP 2: Attempt to convert input to an integer
            // This line may throw a FormatException if the input is not a valid integer.
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You entered: " + number);
        }
        // STEP 3: Catch a specific exception (Format Error)
        catch (FormatException ex)
        {
            // .Message is a property defined in the base Exception class
            Console.WriteLine("Format Exception: " + ex.Message);
        }
        // STEP 4: Global exception handler (Catch-all)
        catch (Exception ex)
        {
            // This catches any other errors that weren't caught by FormatException
            Console.WriteLine("General Exception: " + ex.Message);
        }
        // STEP 5: The Finally block
        finally
        {
            // The FINALLY block is used to clean up resources.
            // It always executes, irrespective of whether an exception was thrown or not.
            Console.WriteLine("This will always execute.");
        }

        Console.WriteLine("\nProgram execution continues after the try-catch block.");
    }
}