using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Puzzle
    {
        List<int> seq1;
        List<int> seq2;
        int count = 0;
        int overlapcount = 0;

        public Puzzle(string[] input)
        {
            foreach (var item in input)
            {
                Parse(item);

                if (getFullyContain())
                {
                    count++;
                }

                if (getOverlap())
                {
                    overlapcount++;
                }
            }
            
            
        }

        public void Parse(string s)
        {
            //example: 2-4,6-8
            Char[] chars = { ',', '-' };
            var array = s.Split(chars);
            var pair1 = Int16.Parse(array[0]);
            var pair2 = Int16.Parse(array[1]);
            var pair3 = Int16.Parse(array[2]);
            var pair4 = Int16.Parse(array[3]);
            seq1 = Enumerable.Range(pair1, pair2-pair1+1).ToList();
            seq2 = Enumerable.Range(pair3, pair4-pair3+1).ToList();

        }

        public bool getFullyContain()
        {
            if (seq1.Count < seq2.Count)
            {
                return seq1.All(i => seq2.Contains(i));
            }
            else
            {
                return seq2.All(i => seq1.Contains(i));
            }
        }

        public bool getOverlap()
        {
            var intersectList = seq1.Intersect(seq2).ToList();
            return (intersectList.Count == 0) ? false : true;
            
        }

        public int Part1()
        {
            return count;
        }

        public int Part2()
        {
            return overlapcount;
        }
       
    }
}
