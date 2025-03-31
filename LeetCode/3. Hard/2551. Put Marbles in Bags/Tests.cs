using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2551._Put_Marbles_in_Bags;

[TestFixture(TestName = "2551. Put Marbles in Bags")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,4,2,5,2]", 3, 3)]
    [TestCase("[1,3,5,1]", 2, 4)]
    [TestCase("[1,3]", 2, 0)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.PutMarbles(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
