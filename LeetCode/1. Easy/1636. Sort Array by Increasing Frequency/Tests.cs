using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1636._Sort_Array_by_Increasing_Frequency;

[TestFixture(TestName = "1636. Sort Array by Increasing Frequency")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,2,2,2,3]", "[3,1,1,2,2,2]")]
    [TestCase("[2,3,1,3,2]", "[1,3,3,2,2]")]
    [TestCase("[-1,1,-6,4,5,-6,1,4,1]", "[5,-1,4,4,-6,-6,1,1,1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FrequencySort(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}