using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3201._Find_the_Maximum_Length_of_Valid_Subsequence_I;

[TestFixture(TestName = "3201. Find the Maximum Length of Valid Subsequence I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3]", 2)]
    [TestCase("[1,2,3,4]", 4)]
    [TestCase("[1,2,1,1,2,1,2]", 6)]
    [TestCase("[1,3]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumLength(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
