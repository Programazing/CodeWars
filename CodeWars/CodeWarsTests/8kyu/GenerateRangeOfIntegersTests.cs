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

    ///
    /// Implement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max,
    /// with the step.The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min<max)
    /// Task
    /// Implement a function named
    /// GenerateRange(2, 10, 2) == new int[]{ 2, 4, 6, 8, 10 }
    /// GenerateRange(1, 10, 3) == new int[]{ 1, 4, 7, 10 }
    /// Note
    ///    min<max
    ///    step > 0
    ///    the range does not HAVE to include max (depending on the step)

}
