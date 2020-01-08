using CodeWars._8kyu;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsTests._8kyu
{
    [TestFixture]
    public class GenerateRangeOfIntegersTests
    {
        [Theory]
        [TestCase(2, 10, 2, new int[] { 2, 4, 6, 8, 10 })]
        public void Test(int min, int max, int step, int[] actual)
        {
            var sut = GenerateRangeOfIntegers.GenerateRange(min, max, step);

            sut.Should().Equal(actual);
        }
    }

}
