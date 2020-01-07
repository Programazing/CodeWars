using CodeWars._8kyu;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTests._8kyu
{
    [TestFixture]
    public class TipCalculatorTests
    {
        [Theory]
        [TestCase(20, "Excellent", 4)]
        [TestCase(26.95, "good", 3)]
        [TestCase(26.95, "meh", -1)]
        [TestCase(23476, "TErriblE", 0)]
        public void Test(double tip, string rating, int actual)
        {
            var result = TipCalculator.CalculateTip(tip, rating);

            result.Should().Be(actual);
        }
    }
}
