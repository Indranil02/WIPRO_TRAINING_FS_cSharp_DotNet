using System;

// Step 1: Define PropertyDemo class
public class PropertyDemo
{
    // Property with a private backing field to demonstrate "Private Value"
    private string _value = "Private Value";
    
    public int Number { get; set; } = 5;

    public string GetValue()
    {
        return _value;
    }
}

// Step 2: Define StaticDemo class
public class StaticDemo
{
    public static int StaticValue = 10;

    // Static constructor - prints "Static Constructor" when class is first used
    static StaticDemo()
    {
        Console.WriteLine("Static Constructor");
    }

    // Static method - prints "Static Method"
    public static void Display()
    {
        Console.WriteLine("Static Method");
    }
}

// Step 3: Define MathHelper static class
public static class MathHelper
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}

public class Program
{
    public static void Main()
    {
        // Step 4: Demonstrate usage to match Expected Output
        
        // 1. Output from PropertyDemo
        PropertyDemo p = new PropertyDemo();
        Console.WriteLine(p.Number);          // Expected: 5
        Console.WriteLine(p.GetValue());      // Expected: Private Value

        // 2. Output from StaticDemo
        // Accessing StaticValue triggers the Static Constructor first
        Console.WriteLine(StaticDemo.StaticValue); // Expected: 10
        StaticDemo.Display();                      // Expected: Static Method

        // 3. Output from MathHelper
        Console.WriteLine(MathHelper.Add(10, 5));      // Expected: 15
        Console.WriteLine(MathHelper.Subtract(10, 5)); // Expected: 5
    }
}