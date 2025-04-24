using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2799._Count_Complete_Subarrays_in_an_Array;

[TestFixture(TestName = "2799. Count Complete Subarrays in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,5,5,5]", 10)]
    [TestCase("[2,2,4,4]", 4)]
    [TestCase("[1,3,1,2,2]", 4)]
    [TestCase("[5,1,1,5]", 5)]
    [TestCase("[1,2,3,4]", 1)]
    [TestCase("[1,2,3,3,2,1]", 7)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountCompleteSubarrays(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}