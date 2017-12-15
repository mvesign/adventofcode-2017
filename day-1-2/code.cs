using System;
using System.IO;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			var digits = File.ReadAllText(@"input.txt");

			long captcha = 0;

			for (int current = 0; current < digits.Length; current++)
			{
                var step = digits.Length / 2;
                var nextStep = current + step;
				var next = nextStep < digits.Length ? nextStep : (nextStep - digits.Length);

				captcha += digits[current] == digits[next] ? Convert.ToInt32($"{digits[current]}") : 0;
			}

			Console.WriteLine($"Captcha: {captcha}");
		}
	}
}