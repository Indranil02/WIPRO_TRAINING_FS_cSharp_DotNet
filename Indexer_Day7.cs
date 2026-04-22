using System;

// Step 1: Define the class
public class TeamRoster
{
    private string[] members = new string[5];

    // Step 2 & 3: Implement the indexer with 'this' and logic
    public string this[int index]
    {
        get 
        { 
            // Add safety logic to prevent crashes
            if (index >= 0 && index < members.Length)
                return members[index];
            return "Out of Bounds";
        }
        set 
        { 
            if (index >= 0 && index < members.Length)
                members[index] = value; 
        }
    }
}

// Step 4: Use the instance
class Program
{
    static void Main()
    {
        TeamRoster blueTeam = new TeamRoster();

        // Using the indexer to SET values
        blueTeam[0] = "Indra";
        blueTeam[1] = "Nil";

        // Using the indexer to GET values
        Console.WriteLine($"Player 1: {blueTeam[0]}");
        Console.WriteLine($"Player 2: {blueTeam[1]}");
    }
}