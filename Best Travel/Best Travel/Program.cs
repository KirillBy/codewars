using System;
using System.Collections.Generic;
using System.Linq;

namespace Best_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ts = new List<int>() { 50, 55, 56, 57, 58 };
            Console.WriteLine(SumOfK.chooseBestSum(163, 3, ts)); 
        }
    }


public static class SumOfK
    {
        public static int? chooseBestSum(int t, int k, List<int> ls) =>
          ls.Combinations(k)
            .Select(c => (int?)c.Sum())
            .Where(sum => sum <= t)
            .DefaultIfEmpty()
            .Max();

        public static IEnumerable<IEnumerable<int>> Combinations(this IEnumerable<int> ls, int k) =>
          k == 0 ? new[] { new int[0] } :
            ls.SelectMany((e, i) =>
              ls.Skip(i + 1)
                .Combinations(k - 1)
                .Select(c => (new[] { e }).Concat(c)));
    }
}
