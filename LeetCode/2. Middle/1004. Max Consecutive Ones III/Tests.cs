using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1004._Max_Consecutive_Ones_III;

[TestFixture(TestName = "1004. Max Consecutive Ones III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,1,0,0,0,1,1,1,1,0]", 2, 6)]
    [TestCase("[0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1]", 3, 10)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestOnes(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
