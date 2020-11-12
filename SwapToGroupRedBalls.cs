using System.Text;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Min_Swaps_to_Group_Red_Balls
{
    class Min_Swaps_to_Group_Red_BallsProgram
    {
        // static void Main(string[] args)
        // {
        //     var RW = new StringBuilder("RW");
        //     for (int i = 0; i < 100000; i++)
        //         RW.Append("RW");

        //     var inputs = new string[] { "RRRWRR", "WRRWWR", "WWRWWWRWR", "WWW", RW.ToString() };

        //     foreach (var input in inputs)
        //         Console.WriteLine("{0} -> {1}", input, MinSwap(input));
        // }

        private static List<int> GetRedIndices(string s)
        {
            var indices = new List<int>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static int MinSwap(string s)
        {
            var redIndices = GetRedIndices(s);
            int mid = redIndices.Count / 2;
            long minSwaps = 0;
            for (int i = 0; i < redIndices.Count; i++)
                minSwaps += Math.Abs(redIndices.ElementAt(mid) - redIndices.ElementAt(i)) - Math.Abs(mid - i);
            return (minSwaps > (long)Math.Pow(10, 9)) ? -1 : (int)minSwaps;
        }
    }
}