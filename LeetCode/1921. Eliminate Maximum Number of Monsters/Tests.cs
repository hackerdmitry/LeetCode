using NUnit.Framework;

namespace LeetCode._1921._Eliminate_Maximum_Number_of_Monsters;

[TestFixture(TestName = "1921. Eliminate Maximum Number of Monsters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,3,4},  new[]{1,1,1}, 3)]
    [TestCase(new[]{1,1,2,3},  new[]{1,1,1,1}, 1)]
    [TestCase(new[]{3,2,4},  new[]{5,3,2}, 1)]
    public void Test(int[] input1, int[] input2, int output)
    {
        var solution = new Solution();
        var actual = solution.EliminateMaximum(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
