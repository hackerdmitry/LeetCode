using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1743._Restore_the_Array_From_Adjacent_Pairs;

[TestFixture(TestName = "1743. Restore the Array From Adjacent Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[][] input, int[] output)
    {
        var solution = new Solution();
        Console.WriteLine("expected: " + string.Join(",", output));
        var actual = solution.RestoreArray(input);
        Console.WriteLine("actual: " + string.Join(",", actual));

        Assert.AreEqual(output.Length, actual.Length);

        for (var i = 1; i < actual.Length; i++)
        {
            for (var j = 0; j < output.Length; j++)
            {
                if (input[j][0] == actual[i - 1] && input[j][1] == actual[i] ||
                    input[j][1] == actual[i - 1] && input[j][0] == actual[i])
                {
                    goto cont;
                }
            }

            throw new Exception($"Не найдена пара [{actual[i - 1]}, {actual[i]}]");
            cont: ;
        }
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[2,1],[3,4],[3,2]]
[1,2,3,4]

[[4,-2],[1,4],[-3,1]]
[-2,4,1,-3]

[[100000,-100000]]
[100000,-100000]

[[-3,-9],[-5,3],[2,-9],[6,-3],[6,1],[5,3],[8,5],[-5,1],[7,2]]
[8,5,3,-5,1,6,-3,-9,2,7]
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
