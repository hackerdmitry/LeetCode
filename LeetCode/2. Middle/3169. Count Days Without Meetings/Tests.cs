using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3169._Count_Days_Without_Meetings;

[TestFixture(TestName = "3169. Count Days Without Meetings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(10, "[[5,7],[1,3],[9,10]]", 2)]
    [TestCase(5, "[[2,4],[1,3]]", 1)]
    [TestCase(6, "[[1,6]]", 0)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountDays(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
