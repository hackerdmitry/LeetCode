using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1289._Minimum_Falling_Path_Sum_II;

[TestFixture(TestName = "1289. Minimum Falling Path Sum II")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinFallingPathSum(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,2,3],[4,5,6],[7,8,9]]
13

[[7]]
7
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
