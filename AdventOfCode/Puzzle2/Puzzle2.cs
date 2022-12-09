using System;
using System.IO;

namespace AdventOfCode.Puzzle2;

public class Puzzle2 : IPuzzle
{
    private int score1 = 0;
    private int score2 = 0;
    public void Solve()
    {
        var input = File.ReadAllLines("puzzle2/input.txt");

        foreach (var line in input)
        {
            var round = line.Split(" ");
            var opponent = round[0];
            var me = round[1];
            score1 += GetRoundScore(opponent, me);
            score1 += GetChoiceScore(me);
            score2 += GetScore2(opponent, me);
        }
        
        Console.WriteLine($"Rock Paper Scissor score1: {score1}");
        Console.WriteLine($"Rock Paper Scissor score2: {score2}");
    }

    private int GetScore2(string opponent, string result)
    {
        var score = 0;

        switch (result)
        {
            case "X":
                score += 0;
                score += GetChoiceScore(opponent) - 1 == 0 ? 3 : GetChoiceScore(opponent) - 1;
                break;
            case "Y":
                score += 3;
                score += GetChoiceScore(opponent);
                break;
            case "Z":
                score += 6;
                score += GetChoiceScore(opponent) + 1 == 4 ? 1 : GetChoiceScore(opponent) + 1;
                break;
        }
        
        return score;
    }

    private int GetChoiceScore(string choice)
    {
        switch (choice)
        {
            case "X":
            case "A":
                return 1;
            case "Y":
            case "B":
                return 2;
            case "Z":
            case "C":
                return 3;
            default:
                return 0;
        }
    }

    private int GetRoundScore(string opponent, string me)
    {
        if (Draw(opponent, me))
        {
            return 3;
        }

        return Win(opponent, me) ? 6 : 0;
    }

    private static bool Draw(string opponent, string me)
    {
        return (opponent == "A" && me == "X") || (opponent == "B" && me == "Y") || (opponent == "C" && me == "Z");
    }

    private static bool Win(string opponent, string me)
    {
        return (opponent == "A" && me == "Y") || (opponent == "B" && me == "Z") || (opponent == "C" && me == "X");
    }
}