using System;
using System.Collections;
using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2225._Find_Players_With_Zero_or_One_Losses;

[TestFixture(TestName = "2225. Find Players With Zero or One Losses")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[][] output)
    {
        var solution = new Solution();
        var actual = solution.FindWinners(input);
        Console.WriteLine($"actual:\n{string.Join(",\n", actual.Select(x => $"[{string.Join(',', x)}]"))}");
        Console.WriteLine($"expected:\n{string.Join(",\n", output.Select(x => $"[{string.Join(',', x)}]"))}");
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,3],[2,3],[3,6],[5,6],[5,7],[4,5],[4,8],[4,9],[10,4],[10,9]]
[[1,2,10],[4,5,7,8]]

[[2,3],[1,3],[5,4],[6,4]]
[[1,2,5,6],[]]

[[1,5],[2,5],[2,8],[2,9],[3,8],[4,7],[4,9],[5,7],[6,8]]
[[1,2,3,4,6],[]]
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
