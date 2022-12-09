// See https://aka.ms/new-console-template for more information
using Day4;

Console.WriteLine("Hello, World!");

Puzzle p = new(File.ReadAllLines("input.txt"));

Console.WriteLine("Part 1 answer is : {0}", p.Part1());
Console.WriteLine("Part 2 answer is : {0}", p.Part2());