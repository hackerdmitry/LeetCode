using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._898._Bitwise_ORs_of_Subarrays;

[TestFixture(TestName = "898. Bitwise ORs of Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0]", 1)]
    [TestCase("[1,1,2]", 3)]
    [TestCase("[1,2,4]", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SubarrayBitwiseORs(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
