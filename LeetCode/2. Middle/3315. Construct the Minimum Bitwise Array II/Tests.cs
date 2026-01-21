using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3315._Construct_the_Minimum_Bitwise_Array_II;

[TestFixture(TestName = "3315. Construct the Minimum Bitwise Array II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,5,7]", "[-1,1,4,3]")]
    [TestCase("[11,13,31]", "[9,12,15]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.MinBitwiseArray(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
