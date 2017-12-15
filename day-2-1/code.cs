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

            var checksum = 0;

            foreach(var line in lines)
            {
                var numbers = line.Split('\t').Select(n => int.Parse(n));
                checksum += numbers.Max() - numbers.Min();
            }

            Console.WriteLine($"Checksum: {checksum}");
		}
	}
}