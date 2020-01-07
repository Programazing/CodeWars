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

    /// Instructions
    ///
    /// Complete the function, which calculates how much you need to tip based on the total amount of the bill and the service.
    /// You need to consider the following ratings:

    /// Terrible: tip 0%
    /// Poor: tip 5%
    /// Good: tip 10%
    /// Great: tip 15%
    /// Excellent: tip 20%

    /// The rating is case insensitive(so "great" = "GREAT"). If an unrecognised rating is received, then you need to return:

    /// "Rating not recognised" in Javascript, Python and Ruby...
    /// ...or null in Java
    /// ...or -1 in C#

    /// Because you're a nice person, you always round up the tip, regardless of the service.

}
