/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        // Dictionary to store total points per player
        // Key: Player ID (string), Value: Total Points (int)
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // Ignore header row

        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);

            // If the player is already in the dictionary, add the points to their total
            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            // If the player is not in the dictionary, add them with the current points
            else
            {
                players[playerId] = points;
            }
        }

        // To find the top 10, we sort the dictionary by value in descending order
        var topPlayers = players.OrderByDescending(p => p.Value).Take(10);

        Console.WriteLine("Top 10 Players by Career Points:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player.Key}: {player.Value}");
        }
    }
}