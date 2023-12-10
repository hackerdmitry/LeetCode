using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._867._Transpose_Matrix;

[TestFixture(TestName = "867. Transpose Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[][] output)
    {
        var solution = new Solution();
        var actual = solution.Transpose(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,2,3],[4,5,6],[7,8,9]]
[[1,4,7],[2,5,8],[3,6,9]]

[[1,2,3],[4,5,6]]
[[1,4],[2,5],[3,6]]
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseIntArray2d();
            var output = lines[1].ParseIntArray2d();
            yield return new object[] { input, output };
        }
    }
}
