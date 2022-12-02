using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode;

public class ElfFoodReader : IEnumerable<int>
{
    private readonly StreamReader reader;

    public ElfFoodReader(StreamReader reader)
    {
        this.reader = reader;
    }

    public IEnumerator<int> GetEnumerator()
    {
        var line = reader.ReadLine();
        var total = 0;
        while (int.TryParse(line, out var calories))
        {
            total += calories;
            line = reader.ReadLine();
        }
        yield return total;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}