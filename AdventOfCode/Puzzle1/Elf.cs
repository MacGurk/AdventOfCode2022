using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Puzzle1;

public class Elf
{
    public List<int> CarriedCalories { get; set; } = new();

    public int TotalCalories => CarriedCalories.Sum();
}