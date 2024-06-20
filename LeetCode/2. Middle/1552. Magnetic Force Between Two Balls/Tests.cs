using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1552._Magnetic_Force_Between_Two_Balls;

[TestFixture(TestName = "1552. Magnetic Force Between Two Balls")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,4,3,2,1,1000000000]", 2, 999999999)]
    [TestCase("[1,2,3,4,7]", 3, 3)]
    [TestCase("[87,56,69,63,99,81,19,28,57,98,82,43,60,88,58,16,4,26,27,40,54,38,85,72,52,65,32,83,22,49,93,75,20,51,55]", 20, 3)]
    [TestCase("[1,2,3,4,5,6,7,8,9,10]", 4, 3)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDistance(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
