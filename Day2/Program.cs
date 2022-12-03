// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

var lines = System.IO.File.ReadAllLines("input.txt");

int totalScoreP1 = 0;
int totalScoreP2 = 0;

foreach (var line in lines)
{
    String[] playerInput = line.Split(" ");
    RPCType A = ParseInput(playerInput[0]);
    RPCType B = ParseInput(playerInput[1]);
    int scoreP1 = EvaluateScorePart1(A, B);
    totalScoreP1 += scoreP1;

    int scoreP2 = EvaluateScorePart2(A, (RPCStatus)B);
    totalScoreP2 += scoreP2;
}

Console.WriteLine("Total evaluated score in Part 1 is {0}, Part2 is {1}", totalScoreP1, totalScoreP2);

static int EvaluateScorePart1(RPCType A, RPCType B)
{
    // return 3 for draw plus value of Rock, Paper, Scissors + 1 for zero adjustment
    if (A == B) return (3 + (int)B + 1);

    // winning conditions - 6 for win, then the value
    else if (A == RPCType.Rock && B == RPCType.Paper) return (6 + (int)B + 1);
    else if (A == RPCType.Scissors && B == RPCType.Rock) return (6 + (int)B + 1);
    else if (A == RPCType.Paper && B == RPCType.Scissors) return (6 + (int)B + 1);
    //losing conditions - 0 for loss, then value
    else if (A == RPCType.Paper && B == RPCType.Rock) return ((int)B + 1);
    else if (A == RPCType.Scissors && B == RPCType.Paper) return ((int)B + 1);
    else if (A == RPCType.Rock && B == RPCType.Scissors) return ((int)B + 1);

    //throw exception for condition not implemented
    throw new NotImplementedException();
}

static int EvaluateScorePart2(RPCType A, RPCStatus B)
{
    // return matching element score + 3 for draw status
    if (B == RPCStatus.draw) return (3 + (int)A + 1);

    else if (B == RPCStatus.lose)
    {
        if (A == RPCType.Rock) return ((int)RPCType.Scissors + 1);
        else if (A == RPCType.Scissors) return ((int)RPCType.Paper + 1);
        else if (A == RPCType.Paper) return ((int)RPCType.Rock + 1);

    }
    else if (B == RPCStatus.win)
    {
        if (A == RPCType.Rock) return (6 + (int)RPCType.Paper + 1);
        else if (A == RPCType.Scissors) return (6 + (int)RPCType.Rock + 1);
        else if (A == RPCType.Paper) return (6 + (int)RPCType.Scissors + 1);
    }

    //throw exception for condition not implemented
    throw new NotImplementedException();
}


static RPCType ParseInput(string input)
{
    switch (input)
    {
        case "A":
            return RPCType.Rock;
        case "B":
            return RPCType.Paper;
        case "C":
            return RPCType.Scissors;
        case "X":
            return RPCType.Rock;
        case "Y":
            return RPCType.Paper;
        case "Z":
            return RPCType.Scissors;
        default:
            break;
    }

    throw new InvalidOperationException();
}