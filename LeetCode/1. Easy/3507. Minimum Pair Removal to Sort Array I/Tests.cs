using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3507._Minimum_Pair_Removal_to_Sort_Array_I;

[TestFixture(TestName = "3507. Minimum Pair Removal to Sort Array I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,2,3,1]", 2)]
    [TestCase("[5,5,3,2]", 1)]
    [TestCase("[1,2,2]", 0)]
    [TestCase("[15,17,1,2,3,4]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumPairRemoval(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
