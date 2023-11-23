using System;
using NUnit.Framework;

namespace LeetCode._2._Middle._1630._Arithmetic_Subarrays;

[TestFixture(TestName = "1630. Arithmetic Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(
        new[] { 4, 6, 5, 9, 3, 7 },
        new[] { 0, 0, 2 },
        new[] { 2, 3, 5 },
        new[] { true, false, true })]
    [TestCase(
        new[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 },
        new[] { 0, 1, 6, 4, 8, 7 },
        new[] { 4, 4, 9, 7, 9, 10 },
        new[] { false, true, false, false, true, true })]
    public void Test(int[] input1, int[] input2, int[] input3, bool[] output)
    {
        var solution = new Solution();
        Console.WriteLine($"output: [{string.Join(',', output)}]");
        var actual = solution.CheckArithmeticSubarrays(input1, input2, input3);
        Console.WriteLine($"actual: [{string.Join(',', actual)}]");
        Assert.AreEqual(output, actual);
    }
}
