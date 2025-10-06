using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._778._Swim_in_Rising_Water;

[TestFixture(TestName = "778. Swim in Rising Water")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,2],[1,3]]", 3)]
    [TestCase("[[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]", 16)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SwimInWater(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
