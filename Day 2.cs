// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//If i want to take user input and siplay it back to the user, i can do it like this:
Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();

//declare a variable to store the user input,
//if the user does not enter anything, it will be set to "Unknown"
Console.WriteLine($"Hello, {name}!");
//display the user input back to the user using string interpolation

