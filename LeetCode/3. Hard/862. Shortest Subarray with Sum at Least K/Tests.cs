using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._862._Shortest_Subarray_with_Sum_at_Least_K;

[TestFixture(TestName = "862. Shortest Subarray with Sum at Least K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[48,99,37,4,-31]", 140, 2)]
    [TestCase("[2,-1,2,1]", 3, 2)]
    [TestCase("[-34,37,51,3,-12,-50,51,100,-47,99,34,14,-13,89,31,-14,-44,23,-38,6]", 151, 2)]
    [TestCase("[84,-37,32,40,95]", 167, 3)]
    [TestCase("[1]", 1, 1)]
    [TestCase("[1,2]", 4, -1)]
    [TestCase("[2,-1,2]", 3, 3)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.ShortestSubarray(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [Test]
    public void BigTest()
    {
        var nums = Enumerable.Repeat(-10_000, 10_000).ToArray();
        var k = 1_000_000_000;
        var expected = -1;
        var actual = new Solution().ShortestSubarray(nums, k);
        Assert.AreEqual(expected, actual);
    }
}