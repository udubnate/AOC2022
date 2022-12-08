// See https://aka.ms/new-console-template for more information
using Day3;

Console.WriteLine("Hello, World!");

var input = File.ReadAllLines("input.txt");

Puzzle p = new Puzzle(input);

Console.WriteLine("Part One answer is : {0}", p.Part1());

Console.WriteLine("Part Two answer is : {0}", p.Part2());

Console.ReadLine();