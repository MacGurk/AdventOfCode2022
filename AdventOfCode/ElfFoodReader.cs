using System.Collections;

namespace AdventOfCode;

public class ElfFoodReader : IEnumerable<Elf>
{
    private StreamReader reader;
    private List<Elf> elves = new List<Elf>();

    public ElfFoodReader(StreamReader reader)
    {
        this.reader = reader;
        GetElves();
    }

    private void GetElves()
    {
        string line;
        int parsedCalories;
        var elf = new Elf();
        while ((line = reader.ReadLine()) != null)
        {
            if (line == "")
            {
                elves.Add(elf);
                elf = new Elf();
            }
            else if (int.TryParse(line, out parsedCalories))
            {
                elf.CarriedCalories.Add(parsedCalories);
            }
        }
    }

    public int GetElfWithMaxCaloriesOfFood()
    {
        return elves.Max(e => e.TotalCalories);
    }

    // public int GetSumOfTopThreeElvesCaloriesOfFood()
    // {
    //     
    // }

    public IEnumerator<Elf> GetEnumerator()
    {
        return elves.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}