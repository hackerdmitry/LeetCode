using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._304._Range_Sum_Query_2D___Immutable;

[TestFixture(TestName = "304. Range Sum Query 2D - Immutable")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test((Func<int> func, int expected)[] tests)
    {
        foreach (var (func, expected) in tests)
        {
            var actual = func();
            Assert.AreEqual(expected, actual);
        }
    }

    private static IEnumerable Input()
    {
        var numMatrix = new NumMatrix("[[[3,0,1,4,2],[5,6,3,2,1],[1,2,0,1,5],[4,1,0,1,7],[1,0,3,0,5]]]".ParseIntArray2d());
        var tests = new (Func<int> func, int expected)[]
        {
            (() => numMatrix.SumRegion(2, 1, 4, 3), 8),
            (() => numMatrix.SumRegion(1, 1, 2, 2), 11),
            (() => numMatrix.SumRegion(1, 2, 2, 4), 12),
        };
        yield return new object[] {tests};
    }
}