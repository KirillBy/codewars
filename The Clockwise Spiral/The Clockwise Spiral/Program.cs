using System;

namespace The_Clockwise_Spiral
{
    class TheClockwiseSpiral
    {
        static void Main()
        {
            CreateSpiral(5);
        }
        public static int[,] CreateSpiral(int N)
        {
            int[,] spiralArray = new int[N, N];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = N;

            for (int i = 0; i < spiralArray.Length; i++)
            {
                spiralArray[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = N * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dy;
                row += dx;
            }
            PrintArray(spiralArray);
            return spiralArray;
        }
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
