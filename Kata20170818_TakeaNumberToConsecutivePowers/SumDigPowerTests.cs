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
                var sumOfPow = i.ToString().ToCharArray().Select((n, idx) => Math.Pow(int.Parse(n.ToString()), idx + 1)).Sum();

                if (sumOfPow == i)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
