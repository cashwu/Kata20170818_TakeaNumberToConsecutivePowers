using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_1_100()
        {
            SumDigPowerShouldBe(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 }, 1, 100);
        }

        [TestMethod]
        public void input_10_100()
        {
            SumDigPowerShouldBe(new long[] { 89 }, 10, 100);
        }

        [TestMethod]
        public void input_90_100()
        {
            SumDigPowerShouldBe(new long[] {}, 90, 100);
        }

        [TestMethod]
        public void input_90_150()
        {
            SumDigPowerShouldBe(new long[] { 135 }, 90, 150);
        }

        [TestMethod]
        public void input_50_150()
        {
            SumDigPowerShouldBe(new long[] { 89, 135 }, 89, 150);
        }

        [TestMethod]
        public void input_10_150()
        {
            SumDigPowerShouldBe(new long[] { 89, 135 }, 10, 150);
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
            var result = new List<long>();

            for (var i = a; i <= b; i++)
            {
                if (i.ToString().Select((n, idx) => Math.Pow(char.GetNumericValue(n), idx + 1)).Sum() == i)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
