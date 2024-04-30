using System;
using NUnit.Framework;

namespace LeetCode._2._Middle._75._Sort_Colors;

[TestFixture(TestName = "75. Sort Colors")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,0,2,1,1,0}, new[]{0,0,1,1,2,2})]
    [TestCase(new[]{2,0,1}, new[]{0,1,2})]
    public void Test(int[] input, int[] output)
    {
        var solution = new Solution();
        solution.SortColors(input);
        Assert.AreEqual(output, input);
    }
}
