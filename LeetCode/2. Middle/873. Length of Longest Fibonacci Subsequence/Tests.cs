using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._873._Length_of_Longest_Fibonacci_Subsequence;

[TestFixture(TestName = "873. Length of Longest Fibonacci Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5,6,7,8]", 5)]
    [TestCase("[1,3,7,11,12,14,18]", 3)]
    [TestCase("[1,3,7,10,17]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LenLongestFibSubseq(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
