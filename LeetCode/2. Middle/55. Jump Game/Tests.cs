using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._55._Jump_Game;

[TestFixture(TestName = "55. Jump Game")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,1,1,4]", true)]
    [TestCase("[3,2,1,0,4]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanJump(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
