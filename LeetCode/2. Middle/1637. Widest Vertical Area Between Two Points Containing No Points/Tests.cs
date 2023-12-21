using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1637._Widest_Vertical_Area_Between_Two_Points_Containing_No_Points;

[TestFixture(TestName = "1637. Widest Vertical Area Between Two Points Containing No Points")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxWidthOfVerticalArea(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[8,7],[9,9],[7,4],[9,7]]
1

[[3,1],[9,0],[1,0],[1,4],[5,3],[8,8]]
3
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
