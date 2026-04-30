using System;

public class Program
{
    public static void Main()
    {
        // --- Step 1 & 2: Type Pattern Matching ---
        // Simulating different types of user input
        object[] inputs = { 42, 3.14159, "Hello World", true };

        Console.WriteLine("--- Type Patterns ---");
        foreach (var input in inputs)
        {
            string typeResult = input switch
            {
                int i => $"Integer: {i} (Squared: {i * i})",
                double d => $"Double: {d} (Precision: 64-bit)",
                string s => $"String: \"{s}\" (Length: {s.Length})",
                _ => $"Other: {input.GetType().Name} detected."
            };
            Console.WriteLine(typeResult);
        }

        // --- Step 3: Tuple Pattern Matching ---
        Console.WriteLine("\n--- Tuple Patterns ---");
        var coordinates = (X: 10, Y: 0);

        string location = coordinates switch
        {
            (0, 0) => "At the origin",
            (var x, 0) => $"On the X-axis at position {x}",
            (0, var y) => $"On the Y-axis at position {y}",
            (var x, var y) => $"In open space at ({x}, {y})"
        };
        Console.WriteLine($"Point {coordinates} is: {location}");

        // --- Step 4: Property Pattern Matching ---
        Console.WriteLine("\n--- Property Patterns ---");
        var myOrder = new Order { Total = 250.00m, MemberStatus = "Gold" };

        string discountStatus = myOrder switch
        {
            { Total: > 200, MemberStatus: "Gold" } => "20% Premium Discount Applied",
            { Total: > 100 } => "10% Standard Discount Applied",
            { MemberStatus: "Gold" } => "Free Shipping for Gold Member",
            _ => "No discounts available"
        };
        Console.WriteLine($"Order (Total: {myOrder.Total}, Status: {myOrder.MemberStatus}): {discountStatus}");
    }
}

public class Order
{
    public decimal Total { get; set; }
    public string MemberStatus { get; set; }
}