using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._45._Jump_Game_II;

[TestFixture(TestName = "45. Jump Game II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1]", 0)]
    [TestCase("[2,3,1,1,4]", 2)]
    [TestCase("[2,3,0,1,4]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.Jump(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
