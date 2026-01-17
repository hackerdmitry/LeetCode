using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3811._Number_of_Alternating_XOR_Partitions;

[TestFixture(TestName = "3811. Number of Alternating XOR Partitions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,1,4]", 1, 5, 1)]
    [TestCase("[1,0,0]", 1, 0, 3)]
    [TestCase("[7]", 1, 7, 0)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.AlternatingXOR(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}