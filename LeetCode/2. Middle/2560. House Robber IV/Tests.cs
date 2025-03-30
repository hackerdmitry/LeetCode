using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2560._House_Robber_IV;

[TestFixture(TestName = "2560. House Robber IV")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,5,9]", 2, 5)]
    [TestCase("[2,7,9,3,1]", 2, 2)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinCapability(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
