using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Rucksack
    {
        List<char> compartmentFirst = new List<char>();
        List<char> compartmentSecond = new List<char>();

        const int lowercaseFix = 96;
        const int uppercaseFix = 38;

        public Rucksack(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (count > input.Length / 2 - 1)
                {
                    compartmentSecond.Add(c);
                }
                else
                {
                    compartmentFirst.Add(c);
                    count++;
                }
            }

        }

        public char findUnique()
        {
            var compareList = compartmentFirst.Intersect(compartmentSecond).ToArray();
            return compareList[0];
        }

        public int getMagicNumber()
        {
            char c = findUnique();
            
            if (Char.IsUpper(c))
            {
                return (int)c - uppercaseFix;
            } else
            {
                return (int)c - lowercaseFix;
            }
        }
    }
}

