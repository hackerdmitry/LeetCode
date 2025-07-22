using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1695._Maximum_Erasure_Value;

[TestFixture(TestName = "1695. Maximum Erasure Value")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,2,4,5,6]", 17)]
    [TestCase("[5,2,1,2,5,2,1,2,5]", 8)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumUniqueSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
