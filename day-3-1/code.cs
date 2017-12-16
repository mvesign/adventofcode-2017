using System;
using System.Linq;

namespace MVESIGN.AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
            var input = 347991;
            
            var position = Program.GetPosition(input);
            
            Console.WriteLine($"Distance: {(Math.Abs(0 - position.Item2) + Math.Abs(0 - position.Item3))}");
		}

        private static int direction = 0;
        private static int distance = 1;
        private static (int, int, int) position = (1, 0, 0);

        public static (int, int, int) GetPosition(int input)
        {
            while(true)
            {
                for (int i = 0; i < 2; ++i)
                {
                    for(int j = 0; j < distance; ++j)
                    {
                        if (position.Item1 == input)
                        {
                            return position;
                        }

                        Move();
                    }

                    direction++;
				    direction = direction % 4;
                }

                distance++;
            }
        }

        private static void Move()
        {
            position.Item1++;

            switch(direction)
            {
                case 0:
                    position.Item2++;
                    break;
                case 1:
                    position.Item3++;
                    break;
                case 2:
                    position.Item2--;
                    break;
                case 3:
                    position.Item3--;
                    break;
            }
        }
	}
}