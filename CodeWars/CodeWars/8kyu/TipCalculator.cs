using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._8kyu
{
    public static class TipCalculator
    {
        public static int CalculateTip(double amount, string rating)
        => TipRatings().ContainsKey(rating.ToLower()) ? (int)Math.Ceiling(TipRatings()[rating.ToLower()] * amount) : -1;

        private static Dictionary<string, double> TipRatings()
        {
            return new Dictionary<string, double>
            {
                { "terrible", 0 },
                { "poor", 0.05 },
                { "good", 0.10 },
                { "great", 0.15 },
                { "excellent", 0.20 },
            };
        }
    }
}
