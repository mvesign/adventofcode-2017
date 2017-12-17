using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
            var current = File.ReadAllText(@"input.txt");
			var banks = current.Split('\t').Select(bank => int.Parse(bank)).ToList();
            var occurences = new List<string>
            {
                current
            };

            while (true)
            {
                var index = banks.IndexOf(banks.Max());
                var value = banks[index];

                banks[index] = 0;
                for (; value > 0; --value)
                {
                    index = (index + 1) == banks.Count ? 0 : index + 1;
                    banks[index]++;
                }

                current = string.Join("\t", banks);
                if (occurences.IndexOf(current) >= 0)
                {
                    break;
                }

                occurences.Add(current);
            }

            Console.WriteLine($"Size of loop: {occurences.Count - occurences.IndexOf(current)}");
		}
	}
}