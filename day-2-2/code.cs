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
                var numbers = line.Split('\t').Select(n => int.Parse(n)).ToArray();
                for (var i = 0; i < numbers.Length; ++i)
                {
                    for (var j = 0; j < numbers.Length; ++j)
                    {
                        if (i != j && numbers[j] % numbers[i] == 0)
                        {
                            checksum += (numbers[j] / numbers[i]);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Checksum: {checksum}");
		}
	}
}