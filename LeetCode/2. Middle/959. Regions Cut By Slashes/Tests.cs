using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._959._Regions_Cut_By_Slashes;

[TestFixture(TestName = "959. Regions Cut By Slashes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\" /\",\"  \"]", 1)]
    [TestCase("[\" /\",\"/ \"]", 2)]
    [TestCase("[\"/\\\",\"\\/\"]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RegionsBySlashes(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}