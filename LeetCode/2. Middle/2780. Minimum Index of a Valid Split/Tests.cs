using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2780._Minimum_Index_of_a_Valid_Split;

[TestFixture(TestName = "2780. Minimum Index of a Valid Split")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,2,2]", 2)]
    [TestCase("[2,1,3,1,1,1,7,1,2,1]", 4)]
    [TestCase("[3,3,3,3,7,2,2]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumIndex(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
