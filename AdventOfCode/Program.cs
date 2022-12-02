// See https://aka.ms/new-console-template for more information

using System.Text;
using AdventOfCode;

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

var listOfElves = new ElfFoodReader(new StreamReader("input.txt"));

var topThree = listOfElves.OrderByDescending(x => x.TotalCalories).Take(3).Sum(e => e.TotalCalories);

//var topThree = orderedList[0].TotalCalories + orderedList[1].TotalCalories + orderedList[2].TotalCalories;

Console.WriteLine(listOfElves.GetElfWithMaxCaloriesOfFood());
Console.WriteLine(topThree);