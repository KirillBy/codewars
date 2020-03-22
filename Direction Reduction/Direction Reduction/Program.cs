using System;
using System.Collections.Generic;

namespace Direction_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            Console.WriteLine(DirReduction.dirReduc(a)); 
        }
        public class DirReduction
        {

            public static string[] dirReduc(String[] arr)
            {
                var arrList = new List<string>();

                foreach (var item in arr)
                {
                    arrList.Add(item);
                }
                for(int i = 0; i < arrList.Count-1; i++)
                {
                    if (Opposide(arrList[i], arrList[i+1]))
                    {
                        arrList.RemoveAt(i+1);
                        arrList.RemoveAt(i);  
                        i = -1;
                    }
                }
                string[] finalArr = arrList.ToArray();
                return finalArr;
            }
            private static bool Opposide(string S1, string S2)
            {
                switch (S1)
                {
                    case "SOUTH": if (S2 == "NORTH") { return true; } else { return false; };
                    case "NORTH": if (S2 == "SOUTH") { return true; } else { return false; }
                    case "WEST": if (S2 == "EAST") { return true; } else { return false; }
                    case "EAST": if (S2 == "WEST") { return true; } else { return false; }
                    default:
                        return false;
                }
            }
        }
    }
}
