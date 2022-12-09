using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Puzzle3;

public class Puzzle3 : IPuzzle
{
    private List<char> _commonItems = new List<char>();
    private List<char> _badges = new List<char>();
    public void Solve()
    {
        var input = File.ReadAllLines("puzzle3/input.txt");

        foreach (var rucksack in input)
        {
            var firstCompartment = rucksack.Substring(0, rucksack.Length / 2);
            var secondCompartment = rucksack.Substring(rucksack.Length / 2);
            var commonItem = 'a';
            foreach (var item in firstCompartment)
            {
                if (secondCompartment.Contains(item))
                {
                    commonItem = item;
                    _commonItems.Add(item);
                    break;
                }
            }
            // Console.WriteLine($"{firstCompartment}, {secondCompartment}: Common Item: {(commonItem)} {((int)commonItem).ToString()}");
        }

        for (var i = 0; i < input.Length; i += 3)
        {
            foreach (var item in input[i])
            {
                if (input[i + 1].Contains(item) && input[i + 2].Contains(item))
                {
                    _badges.Add(item);
                    break;
                }
            }
        }
        
        Console.WriteLine($"Priorities score: {CalculatePriorities(_commonItems)}");
        Console.WriteLine($"Badges score: {CalculatePriorities(_badges)}");
    }
    
    private int CalculatePriorities(List<char> list)
    {
        var score = 0;
        list.ForEach(i =>
        {
            var charAsInt = (int)i;
            if (charAsInt <= 90)
            {
                score += charAsInt - 65 + 27;
            }
            else
            {
                score += charAsInt - 96;
            }
        });

        return score;
    }

}