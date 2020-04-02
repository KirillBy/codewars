using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail

{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };

            int[] resultArray = SnailSolution.Snail(array);
            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            List<int> allElements = new List<int>();
            int finalSize = array.Length * array.Length;
            int sideSize = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                    allElements.Add(array[i][j]);
            }
            List<int> snailedElements = new List<int>();



            while (snailedElements.Count != finalSize)
            {
                int counter = 1;
                for (int i = 0; i < allElements.Count; i++)
                {
                    if (i < sideSize)
                    {
                        snailedElements.Add(allElements[i]);
                        allElements[i] = -1;
                    }
                    else if (counter != sideSize)
                    {

                        counter++;
                    }
                    else
                    {
                        snailedElements.Add(allElements[i]);
                        allElements[i] = -1;
                        counter = 1;
                    }
                }



                sideSize--;
                allElements.RemoveAll(_ => _ == -1);
                allElements.Reverse();

            }

            return snailedElements.ToArray();
        }
    }
}
