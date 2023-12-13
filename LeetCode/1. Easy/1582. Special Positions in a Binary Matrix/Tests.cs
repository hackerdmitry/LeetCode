using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1582._Special_Positions_in_a_Binary_Matrix;

[TestFixture(TestName = "1582. Special Positions in a Binary Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumSpecial(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,0,0],[0,0,1],[1,0,0]]
1

[[1,0,0],[0,1,0],[0,0,1]]
3

[[1,0,0],[1,0,0],[1,0,0]]
0

[[0,0,0,0,0,0,0,0],[0,1,0,0,0,0,0,0],[0,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0],[1,0,0,0,0,0,0,1],[0,0,0,0,0,0,1,0],[0,0,0,0,0,0,0,1]]
2
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
