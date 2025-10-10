using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3147._Taking_Maximum_Energy_From_the_Mystic_Dungeon;

[TestFixture(TestName = "3147. Taking Maximum Energy From the Mystic Dungeon")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,2,-10,-5,1]", 3, 3)]
    [TestCase("[-2,-3,-1]", 2, -1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumEnergy(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
