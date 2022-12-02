namespace AdventOfCode;

public class Elf
{
    public List<int> CarriedCalories { get; set; } = new List<int>();

    public int TotalCalories
    {
        get
        {
            return CarriedCalories.Sum();
        }
    }
}