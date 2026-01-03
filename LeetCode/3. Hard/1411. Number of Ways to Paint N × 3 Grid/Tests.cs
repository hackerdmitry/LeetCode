using NUnit.Framework;

namespace LeetCode._3._Hard._1411._Number_of_Ways_to_Paint_N___3_Grid;

[TestFixture(TestName = "1411. Number of Ways to Paint N × 3 Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 12)]
    [TestCase(2, 54)]
    [TestCase(5000, 30228214)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumOfWays(input);
        Assert.AreEqual(output, actual);
    }
}
