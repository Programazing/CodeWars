using System;
using System.Linq;
using System.Text;

namespace CodeWars._8kyu
{
    public static class GenerateRangeOfIntegers
    {
        public static int[] GenerateRange(int min, int max, int step)
        => Enumerable.Range(0, 1 + (max - min) / step).Select(i => min + i * step).ToArray();
    }
}
