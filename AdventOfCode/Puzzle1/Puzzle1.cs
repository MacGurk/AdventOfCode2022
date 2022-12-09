using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Puzzle1;

public class Puzzle1 : IPuzzle
{
    public void Solve()
    {
        var listOfElves = new ElfFoodReader(new StreamReader("puzzle1/input.txt"));

        var topThree = listOfElves.OrderByDescending(x => x.TotalCalories).Take(3).Sum(e => e.TotalCalories);
        
        Console.WriteLine(listOfElves.Max(e => e.TotalCalories));
        Console.WriteLine(topThree);
    }
}