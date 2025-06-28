using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2099._Find_Subsequence_of_Length_K_With_the_Largest_Sum;

[TestFixture(TestName = "2099. Find Subsequence of Length K With the Largest Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3,3]", 2, "[3,3]")]
    [TestCase("[-1,-2,3,4]", 3, "[-1,3,4]")]
    [TestCase("[3,4,3,3]", 2, "[3,4]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MaxSubsequence(input1.ParseIntArray(), input2);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}