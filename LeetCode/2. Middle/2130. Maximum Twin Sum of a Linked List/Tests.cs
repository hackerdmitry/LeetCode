using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2130._Maximum_Twin_Sum_of_a_Linked_List;

[TestFixture(TestName = "2130. Maximum Twin Sum of a Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,4,2,1]", 6)]
    [TestCase("[4,2,2,3]", 7)]
    [TestCase("[1,100000]", 100001)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.PairSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
