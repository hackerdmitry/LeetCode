using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3186._Maximum_Total_Damage_With_Spell_Casting;

[TestFixture(TestName = "3186. Maximum Total Damage With Spell Casting")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,3,4]", 6)]
    [TestCase("[7,1,6,6]", 13)]
    [TestCase("[1,1,3,4,5]", 7)]
    [TestCase("[1,6,6,7,8,8,9]", 22)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MaximumTotalDamage(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}