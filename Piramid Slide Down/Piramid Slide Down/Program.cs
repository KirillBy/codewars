using System;
using System.Collections.Generic;

namespace Piramid_Slide_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class PyramidSlideDown
    {
		public static int LongestSlideDown(int[][] pyramid)
		{
			var cache = new Dictionary<string, int>();
			return LongestSlideDownAt(pyramid, 0, 0, cache);
		}

		private static int LongestSlideDownAt(int[][] pyramid, int x, int y, Dictionary<string, int> cache)
		{
			if (x >= pyramid.Length || y >= pyramid[x].Length)
			{
				return 0;
			}

			if (x == pyramid.Length - 1)
			{
				return pyramid[x][y];
			}

			string key = $"{x}:{y}";
			if (cache.ContainsKey(key))
			{
				return cache[key];
			}

			int max = int.MinValue;
			for (int i = 0; i < 2; i++)
			{
				int tmp = LongestSlideDownAt(pyramid, x + 1, y + i, cache);
				if (tmp > max)
				{
					max = tmp;
				}
			}

			cache[key] = pyramid[x][y] + max;
			return cache[key];
		}
	}
}
