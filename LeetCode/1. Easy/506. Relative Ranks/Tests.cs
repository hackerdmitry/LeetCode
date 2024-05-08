using System;
using NUnit.Framework;

namespace LeetCode._1._Easy._506._Relative_Ranks;

[TestFixture(TestName = "506. Relative Ranks")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{5,4,3,2,1}, new[]{"Gold Medal","Silver Medal","Bronze Medal","4","5"})]
    [TestCase(new[]{10,3,8,9,4}, new[]{"Gold Medal","5","Bronze Medal","Silver Medal","4"})]
    public void Test(int[] input, string[] output)
    {
        var solution = new Solution();
        var actual = solution.FindRelativeRanks(input);
        Console.WriteLine($"actual: [{string.Join(", ", actual)}]");
        Console.WriteLine($"expected: [{string.Join(", ", output)}]");
        Assert.AreEqual(output, actual);
    }
}
