using System;
using System.IO;           
using System.Reflection;    


// 1. ATTRIBUTES & REFLECTION

[AttributeUsage(AttributeTargets.Class)]
public class AppMetadata : Attribute {
    public string Description { get; }
    public AppMetadata(string desc) => Description = desc;
}


// 2. DEFAULT INTERFACE METHODS (C# 8)

public interface ILogger {
    void Log(string message);
    // Default logic in an interface
    void PrintHeader() => Console.WriteLine("--- System Log Entry ---");
}

public class FileLogger : ILogger {
    public void Log(string message) {
        try {
            // 3. USING DECLARATION (C# 8)
            // Automatically closes the file when the method ends
            using var writer = new StreamWriter("log_report.txt", true);
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
        catch (IOException ex) {
            Console.WriteLine($"[Exception] File Error: {ex.Message}");
        }
    }
}

// 4. MAIN ENGINE (Tuples, Events, Patterns)
[AppMetadata("Demonstrating C# 7 & 8 Advanced Features")]
public class DataEngine {
    // 5. DELEGATES & EVENTS
    public event Action<string> OnProcessComplete;

    // 6. TUPLES & DECONSTRUCTION (C# 7)
    public (bool Success, string Msg) ProcessData(object input) {
        
        // 7. LOCAL FUNCTIONS (C# 7)
        static string Clean(string text) => text.Trim();

        // 8. SWITCH EXPRESSIONS & PATTERN MATCHING (C# 8)
        string result = input switch {
            int i when i > 100 => $"Large Number: {i}", 
            int i              => $"Small Number: {i}",
            string s           => $"Text: {Clean(s)}",
            null               => throw new ArgumentNullException(),
            _                  => "Unknown Format" 
        };

        OnProcessComplete?.Invoke(result);
        return (true, result); 
    }
}


// 5. EXECUTION LAYER (User Input & Logic)
class Program {
    static void Main() {
        // --- REFLECTION ---
        var meta = typeof(DataEngine).GetCustomAttribute<AppMetadata>();
        Console.WriteLine(meta?.Description);

        var engine = new DataEngine();
        var logger = new FileLogger();

        // --- EVENT SUBSCRIPTION ---
        engine.OnProcessComplete += logger.PrintHeader;
        engine.OnProcessComplete += logger.Log;

        // --- USER INPUT ---
        Console.Write("\nEnter a number or some text: ");
        string rawInput = Console.ReadLine();

        // 9. NULL-COALESCING ASSIGNMENT (C# 8)
        rawInput ??= "No Input Provided";

        // 10. OUT VARIABLES (C# 7)
        object finalData;
        if (int.TryParse(rawInput, out int numericValue)) {
            finalData = numericValue;
        } else {
            finalData = rawInput;
        }

        // --- DECONSTRUCTION ---
        var (isSuccess, finalMsg) = engine.ProcessData(finalData);

        Console.WriteLine($"\nOutput: {finalMsg}");
        Console.WriteLine("Data has been saved to log_report.txt.");
    }
}