using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode;

public class Elf
{
    public List<int> CarriedCalories { get; set; } = new();

    public int TotalCalories => CarriedCalories.Sum();
}