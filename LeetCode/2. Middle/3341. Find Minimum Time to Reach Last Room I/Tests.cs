using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3341._Find_Minimum_Time_to_Reach_Last_Room_I;

[TestFixture(TestName = "3341. Find Minimum Time to Reach Last Room I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[56,93],[3,38]]", 39)]
    [TestCase("[[17,56],[97,80]]", 81)]
    [TestCase("[[15,58],[67,4]]", 60)]
    [TestCase("[[0,4],[4,4]]", 6)]
    [TestCase("[[0,0,0],[0,0,0]]", 3)]
    [TestCase("[[0,1],[1,2]]", 3)]
    [TestCase("[0,0,0,0,0],[99,99,99,99,0],[0,0,0,0,0],[0,99,99,99,99],[0,0,0,0,0]", 16)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinTimeToReach(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
