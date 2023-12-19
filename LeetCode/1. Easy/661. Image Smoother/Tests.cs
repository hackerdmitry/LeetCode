using System;
using System.Collections;
using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._661._Image_Smoother;

[TestFixture(TestName = "661. Image Smoother")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[][] output)
    {
        var solution = new Solution();
        var actual = solution.ImageSmoother(input);
        Console.WriteLine($"output:\n{string.Join(",\n", output.Select(x => $"[{string.Join(',', x)}]"))}");
        Console.WriteLine($"actual:\n{string.Join(",\n", actual.Select(x => $"[{string.Join(',', x)}]"))}");
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[1,1,1],[1,0,1],[1,1,1]]
[[0,0,0],[0,0,0],[0,0,0]]

[[100,200,100],[200,50,200],[100,200,100]]
[[137,141,137],[141,138,141],[137,141,137]]

[[2,3,4],[5,6,7],[8,9,10],[11,12,13],[14,15,16]]
[[4,4,5],[5,6,6],[8,9,9],[11,12,12],[13,13,14]]
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
