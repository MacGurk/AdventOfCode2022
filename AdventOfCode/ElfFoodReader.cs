using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode;

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
        var line = reader.ReadLine();
        if (!string.IsNullOrEmpty(line) && int.TryParse(line, out var parsedCalories))
        {
            elf.CarriedCalories.Add(parsedCalories);
            yield return elf;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}