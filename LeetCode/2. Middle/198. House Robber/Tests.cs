using NUnit.Framework;

namespace LeetCode._2._Middle._198._House_Robber;

[TestFixture(TestName = "198. House Robber")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,3,1}, 4)]
    [TestCase(new[]{2,7,9,3,1}, 12)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new int[0], 0)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.Rob(input);
        Assert.AreEqual(output, actual);
    }
}
