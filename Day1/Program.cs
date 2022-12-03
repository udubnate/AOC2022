using System.Security.Cryptography;
using static System.Net.WebRequestMethods;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("input.txt");

            List<Int32> Elfs = new List<Int32>();

            Elfs.Add(0);
            int count = 0;
            int maxPtr = 0;

            foreach (var line in lines)
            {
                if (line.Length == 0)
                {             
                    Elfs.Add(0);
                    count++;

                    
                }
                else {
                    Elfs[count] += Int32.Parse(line);
                }
                
            }

            Elfs.Sort();
            Elfs.Reverse();

            //Task.Run(new Action());
            Console.ReadLine();
            foreach (var elf in Elfs)
            {
                Console.WriteLine(elf);
            }
            Console.WriteLine("Part1: {0}, Part2: {1}", Elfs[0], Elfs[0] + Elfs[1] + Elfs[2]);


        }

    }
}