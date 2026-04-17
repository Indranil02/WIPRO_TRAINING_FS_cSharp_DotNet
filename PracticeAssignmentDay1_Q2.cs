using System;
namespace codeEvalAssignment
{
class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        // Complete Step 1:............
        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        // Complete Step 2:............
        // Add the two numbers
        int sum =num1+num2;
        // Complete Step 3:............
        // Print the sum
        Console.WriteLine($"The sum is: {sum}");
        // Complete Step 4:............
    }
}
}