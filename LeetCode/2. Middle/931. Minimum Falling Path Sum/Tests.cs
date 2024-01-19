using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._931._Minimum_Falling_Path_Sum;

[TestFixture(TestName = "931. Minimum Falling Path Sum")]
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
[[2,1,3],[6,5,4],[7,8,9]]
13

[[-19,57],[-40,-5]]
-59

[[1,1,1],[2,1,1],[2,2,1],[2,9,9]]
6
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
