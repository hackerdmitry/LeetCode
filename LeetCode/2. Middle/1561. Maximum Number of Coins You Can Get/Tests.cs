using NUnit.Framework;

namespace LeetCode._2._Middle._1561._Maximum_Number_of_Coins_You_Can_Get;

[TestFixture(TestName = "1561. Maximum Number of Coins You Can Get")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,4,1,2,7,8}, 9)]
    [TestCase(new[]{2,4,5}, 4)]
    [TestCase(new[]{9,8,7,6,5,1,2,3,4}, 18)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxCoins(input);
        Assert.AreEqual(output, actual);
    }
}
