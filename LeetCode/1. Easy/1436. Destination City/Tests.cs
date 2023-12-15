using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1436._Destination_City;

[TestFixture(TestName = "1436. Destination City")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(string[][] input, string output)
    {
        var solution = new Solution();
        var actual = solution.DestCity(input);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[[""London"",""New York""],[""New York"",""Lima""],[""Lima"",""Sao Paulo""]]
Sao Paulo

[[""B"",""C""],[""D"",""B""],[""C"",""A""]]
A

[[""A"",""Z""]]
Z
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input = lines[0].ParseStringArray2d();
            var output = lines[1];
            yield return new object[] { input, output };
        }
    }
}
