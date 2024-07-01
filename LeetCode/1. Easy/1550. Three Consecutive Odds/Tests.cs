using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1550._Three_Consecutive_Odds;

[TestFixture(TestName = "1550. Three Consecutive Odds")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,6,4,1]", false)]
    [TestCase("[1,2,34,3,4,5,7,23,12]", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.ThreeConsecutiveOdds(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
