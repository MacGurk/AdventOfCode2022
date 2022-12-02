// var inputList = File.ReadLines("input.txt", Encoding.Default);
// var inputList
// var listOfElves = new List<Elf> { new Elf() };
//
// foreach (var food in inputList)
// {
//     if (food == "")
//     {
//         listOfElves.Add(new Elf());
//     }
//     else
//     {
//         listOfElves[^1].CarriedCalories.Add(int.Parse(food));
//     }
// }

using System;
using System.IO;
using System.Linq;
using AdventOfCode;

var listOfElves = new ElfFoodReader(new StreamReader("input.txt"));

var topThree = listOfElves.OrderByDescending(x => x.TotalCalories).Take(3).Sum(e => e.TotalCalories);

//var topThree = orderedList[0].TotalCalories + orderedList[1].TotalCalories + orderedList[2].TotalCalories;

Console.WriteLine(listOfElves.Max(e => e.TotalCalories));
Console.WriteLine(topThree);