using System;
using System.Linq;
using AdventOfCode;

var puzzlesTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()).Where(t => typeof(IPuzzle).IsAssignableFrom(t) && t.IsClass);

var puzzles = puzzlesTypes.Select(puzzle => Activator.CreateInstance(puzzle) as IPuzzle).ToList();

puzzles.ForEach(p => p.Solve());