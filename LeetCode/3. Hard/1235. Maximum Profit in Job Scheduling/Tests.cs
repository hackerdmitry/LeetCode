using System;
using System.Collections;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1235._Maximum_Profit_in_Job_Scheduling;

[TestFixture(TestName = "1235. Maximum Profit in Job Scheduling")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int[] input1, int[] input2, int[] input3, int output)
    {
        var solution = new Solution();
        var actual = solution.JobScheduling(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        var testCasesString = @"
[1,2,3,3]
[3,4,5,6]
[50,10,40,70]
120

[1,2,3,4,6]
[3,5,10,6,9]
[20,20,100,70,60]
150

[1,1,1]
[2,3,4]
[5,6,4]
6

[24,24,7,2,1,13,6,14,18,24]
[27,27,20,7,14,22,20,24,19,27]
[6,1,4,2,3,6,5,6,9,8]
20
".Trim();

        var testCases = testCasesString.Split(
            Environment.NewLine + Environment.NewLine,
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var testCase in testCases)
        {
            var lines = testCase.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var input1 = lines[0].ParseIntArray();
            var input2 = lines[1].ParseIntArray();
            var input3 = lines[2].ParseIntArray();
            var output = lines[3].ParseInt();
            yield return new object[] { input1, input2, input3, output };
        }
    }
}
