using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1727._Largest_Submatrix_With_Rearrangements;

[TestFixture(TestName = "1727. Largest Submatrix With Rearrangements")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int number, int[][] input, int output)
    {
        var solution = new Solution();
        var actual = solution.LargestSubmatrix(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[0,0,1],[1,1,1],[1,0,1]]
4

[[1,0,1,0,1]]
3

[[1,1,0],[1,0,1]]
2

[[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,0,1,1],[0,1,1,0,1,1,1,1,0,1,1,0,0,1,0,1,1,1,1,0,1,1,1,1,1,1]]
34
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        var index = 1;
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseIntArray2d();
            var output = lines[1].ParseInt();
            yield return new object[] { index++, input, output };
        }
    }
}
