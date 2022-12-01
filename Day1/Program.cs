using static System.Net.WebRequestMethods;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("input.txt");

            List<int> Elfs = new List<int>();

            Elfs.Add(0);
            int count = 0;
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

            //Task.Run(new Action());
            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }

    }
}