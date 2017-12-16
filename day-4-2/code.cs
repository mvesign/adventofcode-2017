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
                
                var ordendWords = words.Select(word => string.Concat(word.OrderBy(c => c)));
                
                valid += ordendWords.Distinct().Count() == ordendWords.Count() ? 1 : 0;
            }

            Console.WriteLine($"Valid: {valid}");
		}
	}
}