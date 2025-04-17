using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2176._Count_Equal_and_Divisible_Pairs_in_an_Array;

[TestFixture(TestName = "2176. Count Equal and Divisible Pairs in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,1,2,2,2,1,3]", 2, 4)]
    [TestCase("[1,2,3,4]", 1, 0)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountPairs(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
