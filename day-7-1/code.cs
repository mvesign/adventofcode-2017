using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
            var regex = new Regex(@"^(?<name>\w+)\s[(](?<weigth>\d+)[)](\s->\s(?<programs>[\w,\s]+))*$", RegexOptions.IgnoreCase);

            var programs = File
                .ReadAllLines(@"C:\Projects\GitHub\mvesign-adventofcode-2017\day-7-1\input.txt")
                .Select(program =>
                {
                    var match = regex.Match(program);

                    return new {
                        Name = match.Groups["name"].Value,
                        Weigth = int.Parse(match.Groups["weigth"].Value),
                        Programs = match.Groups["programs"].Value.Replace(" ", "").Split(',').Where(value => !string.IsNullOrWhiteSpace(value))
                    };
                });

            var childPrograms = programs
                .Where(program => program.Programs.Any())
                .SelectMany(program => program.Programs);

            var bottomProgram = programs.Select(p => p.Name).Except(childPrograms).FirstOrDefault();
            
            Console.WriteLine($"Bottom program: {bottomProgram}");
		}
	}
}