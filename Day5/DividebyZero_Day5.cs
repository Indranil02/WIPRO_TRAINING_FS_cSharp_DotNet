using System;

class Program
{
    static void Main()
    {
        try
        {
            // 1. Get the numerator
            Console.Write("Enter the number to be divided: ");
            int num = int.Parse(Console.ReadLine());

            // 2. Get the denominator
            Console.Write("Enter the divisor: ");
            int div = int.Parse(Console.ReadLine());

            // 3. Perform division
            int result = num / div;
            Console.WriteLine($"\nSuccess! {num} divided by {div} is: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("\nError: Logic failure. You cannot an integer divide by zero.");
        }
       catch (FormatException)
        {
            Console.WriteLine("\nError: Please enter whole numbers only.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Thank you for using the program.");
        }
    }
}
