using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Puzzle1;

public class ElfFoodReader : IEnumerable<Elf>
{
    private StreamReader reader;

    public ElfFoodReader(StreamReader reader)
    {
        this.reader = reader;
    }

    public IEnumerator<Elf> GetEnumerator()
    {
        var elf = new Elf();
        string line;
        // var line = reader.ReadLine();
        while (!string.IsNullOrEmpty(line = reader.ReadLine()) && int.TryParse(line, out var parsedCalories))
        {
            elf.CarriedCalories.Add(parsedCalories);
        }

        yield return elf;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}