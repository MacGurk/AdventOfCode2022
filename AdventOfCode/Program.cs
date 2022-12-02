using System;
using System.IO;
using System.Linq;
using AdventOfCode;

var totalCalories = new ElfFoodReader(new StreamReader("input.txt"));
Console.WriteLine(totalCalories.Max());
