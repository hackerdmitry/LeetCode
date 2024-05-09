using NUnit.Framework;

namespace LeetCode._2._Middle._3075._Maximize_Happiness_of_Selected_Children;

[TestFixture(TestName = "3075. Maximize Happiness of Selected Children")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,3}, 2, 4)]
    [TestCase(new[]{1,1,1,1}, 2, 1)]
    [TestCase(new[]{2,3,4,5}, 1, 5)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumHappinessSum(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
