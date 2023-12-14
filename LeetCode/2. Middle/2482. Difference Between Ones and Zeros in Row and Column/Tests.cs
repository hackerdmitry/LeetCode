using System;
using System.Collections;
using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2482._Difference_Between_Ones_and_Zeros_in_Row_and_Column;

[TestFixture(TestName = "2482. Difference Between Ones and Zeros in Row and Column")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[][] output)
    {
        var solution = new Solution();
        Console.WriteLine($"output:\n{string.Join(",\n", output.Select(x => $"[{string.Join(',', x)}]"))}");
        var actual = solution.OnesMinusZeros(input);
        Console.WriteLine($"actual:\n{string.Join(",\n", actual.Select(x => $"[{string.Join(',', x)}]"))}");
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[0,1,1],[1,0,1],[0,0,1]]
[[0,0,4],[0,0,4],[-2,-2,2]]

[[1,1,1],[1,1,1]]
[[5,5,5],[5,5,5]]
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
