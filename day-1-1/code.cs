using System;

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
				var next = current + 1 == digits.Length ? 0 : (current + 1);
				captcha += digits[current] == digits[next] ? Convert.ToInt32($"{digits[current]}") : 0;
			}

			Console.WriteLine($"Captcha: {captcha}");
		}
	}
}