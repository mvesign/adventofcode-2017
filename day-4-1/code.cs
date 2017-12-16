using System;
using System.IO;
using System.Linq;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
            var lines = File.ReadAllLines(@"input.txt");

            var valid = 0;

            foreach(var line in lines)
            {
                var words = line.Split(' ');
                valid += words.Distinct().Count() == words.Count() ? 1 : 0;
            }

            Console.WriteLine($"Valid: {valid}");
		}
	}
}