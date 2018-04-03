using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var team = new Team("my team");
        var personCount = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < personCount; i++)
        {
            var input = Console.ReadLine().Split();
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReverseTeam.Count} players.");
    }
}