using System;
using System.Collections.Generic;
using System.Linq;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
            var input = 347991;
            
            Console.WriteLine($"First larger value: {Program.GetFirstLargerValue(input)}");
		}

        private static List<(int, int)> adjacents = new List<(int, int)>
        {
            (1, 1), (1, 0), (1, -1), (0, 1), (0, -1), (-1, 1), (-1, 0), (-1, -1)
        };
        private static int direction = 0;
        private static int distance = 1;
        private static (int, int) position = (0, 0);
        private static Dictionary<(int, int), int> positions = new Dictionary<(int, int), int>
        {
            { (0, 0), 1 }
        };

        public static int GetFirstLargerValue(int input)
        {
            while(true)
            {
                for (int i = 0; i < 2; ++i)
                {
                    for(int j = 0; j < distance; ++j)
                    {
                        if (positions[position] >= input)
                        {
                            return positions[position];
                        }

                        Move();

                        positions.Add(position, GetSumOfAdjacents());
                    }

                    direction++;
				    direction = direction % 4;
                }

                distance++;
            }
        }

        private static int GetAdjacent(int x, int y)
        {
            return positions.ContainsKey((x, y)) ? positions[(x, y)] : 0;
        }

        private static int GetSumOfAdjacents()
        {
            return adjacents.Select(a => GetAdjacent(position.Item1 + a.Item1, position.Item2 + a.Item2)).Sum();
        }

        private static void Move()
        {
            switch(direction)
            {
                case 0:
                    position.Item1++;
                    break;
                case 1:
                    position.Item2++;
                    break;
                case 2:
                    position.Item1--;
                    break;
                case 3:
                    position.Item2--;
                    break;
            }
        }
	}
}