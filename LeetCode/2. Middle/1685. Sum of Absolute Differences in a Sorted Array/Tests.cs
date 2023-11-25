using System;
using NUnit.Framework;

namespace LeetCode._2._Middle._1685._Sum_of_Absolute_Differences_in_a_Sorted_Array;

[TestFixture(TestName = "1685. Sum of Absolute Differences in a Sorted Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,3,5}, new[]{4,3,5})]
    [TestCase(new[]{1,4,6,8,10}, new[]{24,15,13,15,21})]
    public void Test(int[] input, int[] output)
    {
        var solution = new Solution();
        Console.WriteLine($"output: [{string.Join(',', output)}]");
        var actual = solution.GetSumAbsoluteDifferences(input);
        Console.WriteLine($"actual: [{string.Join(',', actual)}]");
        Assert.AreEqual(output, actual);
    }
}
