using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2134._Minimum_Swaps_to_Group_All_1_s_Together_II;

[TestFixture(TestName = "2134. Minimum Swaps to Group All 1's Together II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,0,0]", 0)]
    [TestCase("[1,1,1,0,0,1,0,1,1,0]", 1)]
    [TestCase("[1,1,0,0,1]", 0)]
    [TestCase("[0,1,0,1,1,0,0]", 1)]
    [TestCase("[0,1,1,1,0,0,1,1,0]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinSwaps(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}