using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3487._Maximum_Unique_Subarray_Sum_After_Deletion;

[TestFixture(TestName = "3487. Maximum Unique Subarray Sum After Deletion")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 15)]
    [TestCase("[1,1,0,1,1]", 1)]
    [TestCase("[1,2,-1,-2,1,0,-1]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
