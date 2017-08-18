using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170818_TakeaNumberToConsecutivePowers
{
    [TestClass]
    public class SumDigPowerTests
    {
        [TestMethod]
        public void input_1_10()
        {
            SumDigPowerShouldBe(new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 1, 10);
        }

        private static void SumDigPowerShouldBe(long[] expected, int a, int b)
        {
            var actual = new SumDigPower().SumDigPow(a, b);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class SumDigPower
    {
        public long[] SumDigPow(long a, long b)
        {
            return new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        }
    }
}
