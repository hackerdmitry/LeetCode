using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2598._Smallest_Missing_Non_negative_Integer_After_Operations;

[TestFixture(TestName = "2598. Smallest Missing Non-negative Integer After Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,0,3,2,4,2,1,1,0,4]", 5, 10)]
    [TestCase("[1,-10,7,13,6,8]", 5, 4)]
    [TestCase("[1,-10,7,13,6,8]", 7, 2)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindSmallestInteger(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
