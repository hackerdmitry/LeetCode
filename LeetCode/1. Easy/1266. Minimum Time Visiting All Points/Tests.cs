using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1266._Minimum_Time_Visiting_All_Points;

[TestFixture(TestName = "1266. Minimum Time Visiting All Points")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinTimeToVisitAllPoints(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,1],[3,4],[-1,0]]
7

[[3,2],[-2,2]]
5
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseIntArray2d();
            var output = lines[1].ParseInt();
            yield return new object[] { input, output };
        }
    }
}
