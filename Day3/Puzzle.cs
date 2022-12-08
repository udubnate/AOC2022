using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Puzzle
    {

        List<Rucksack> rucksacks = new List<Rucksack>();
        List<char> uniqueItems = new List<char>();
        List<int> magicItems = new List<int>();
        int magicItemsum = 0;

        public Puzzle(string[] input)
        {
           foreach (var item in input)
            {
                Rucksack r = new Rucksack(item);
                rucksacks.Add(r);
                uniqueItems.Add(r.findUnique());
                magicItems.Add(r.getMagicNumber());
            }
        }

        public int Part1()
        {
            // get Sum of all magic items
            return magicItems.Sum();

        }

        public int Part2()
        {
            List<int> Matches = new();

            for (int i = 0; i < rucksacks.Count; i += 3)
            { 
                var matchingSack  = rucksacks[i].fullsack.Intersect(rucksacks[i + 1].fullsack);
                var allMatches = matchingSack.Intersect(rucksacks[i+2].fullsack).ToArray();
                Matches.Add(rucksacks[i].getMagicNumber(allMatches[0]));
           
            }
            return Matches.Sum();
        }


    }
}
