using System;
using System.IO;
using System.Linq;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			var offsets = File.ReadAllLines(@"input.txt").ToList().Select(offset => int.Parse(offset)).ToArray();

			int steps = 0;

			for (int current = 0; current < offsets.Length; ++steps)
			{
				var offset = offsets[current];

				offsets[current]++;

				current += offset;
			}

			Console.WriteLine($"Number of steps: {steps}");
		}
	}
}