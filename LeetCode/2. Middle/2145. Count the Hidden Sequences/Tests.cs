using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2145._Count_the_Hidden_Sequences;

[TestFixture(TestName = "2145. Count the Hidden Sequences")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,-3,4]", 1, 6, 2)]
    [TestCase("[3,-4,5,1,-2]", -4, 5, 4)]
    [TestCase("[4,-7,2]", 3, 6, 0)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfArrays(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
