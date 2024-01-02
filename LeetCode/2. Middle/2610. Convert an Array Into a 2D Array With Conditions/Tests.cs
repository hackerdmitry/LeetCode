using System;
using System.Collections;
using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2610._Convert_an_Array_Into_a_2D_Array_With_Conditions;

[TestFixture(TestName = "2610. Convert an Array Into a 2D Array With Conditions")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[] input, int[][] output)
    {
        var solution = new Solution();
        var actual = solution.FindMatrix(input);
        Console.WriteLine($"output:\n{string.Join(",\n", output.Select(x => $"[{string.Join(',', x)}]"))}");
        Console.WriteLine($"actual:\n{string.Join(",\n", actual.Select(x => $"[{string.Join(',', x)}]"))}");
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[1,3,4,1,2,3,1]
[[1,3,4,2],[1,3],[1]]

[1,2,3,4]
[[4,3,2,1]]
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseIntArray();
            var output = lines[1].ParseIntArray2d();
            yield return new object[] { input, output };
        }
    }
}
