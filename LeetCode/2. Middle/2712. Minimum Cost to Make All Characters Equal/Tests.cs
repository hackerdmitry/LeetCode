using NUnit.Framework;

namespace LeetCode._2._Middle._2712._Minimum_Cost_to_Make_All_Characters_Equal;

[TestFixture(TestName = "2712. Minimum Cost to Make All Characters Equal")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("010101", 9)]
    [TestCase("0011", 2)]
    [TestCase("00", 0)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input);
        Assert.AreEqual(output, actual);
    }
}
