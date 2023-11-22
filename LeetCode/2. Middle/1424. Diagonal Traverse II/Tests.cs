using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1424._Diagonal_Traverse_II;

[TestFixture(TestName = "1424. Diagonal Traverse II")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[] output)
    {
        var solution = new Solution();
        Console.WriteLine($"output: [{string.Join(',', output)}]");
        var actual = solution.FindDiagonalOrder(input);
        Console.WriteLine($"actual: [{string.Join(',', actual)}]");
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,2,3],[4,5,6],[7,8,9]]
[1,4,2,7,5,3,8,6,9]

[[1,2,3,4,5],[6,7],[8],[9,10,11],[12,13,14,15,16]]
[1,6,2,8,7,3,9,4,12,10,5,13,11,14,15,16]

[[14,12,19,16,9],[13,14,15,8,11],[11,13,1]]
[14,13,12,11,14,19,13,15,16,1,8,9,11]
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseIntArray2d();
            var output = lines[1].ParseIntArray();
            yield return new object[] { input, output };
        }
    }
}
