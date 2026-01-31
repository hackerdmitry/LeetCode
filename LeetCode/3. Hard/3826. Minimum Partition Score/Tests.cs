using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3826._Minimum_Partition_Score;

[TestFixture(TestName = "3826. Minimum Partition Score")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,1,2,1]", 2, 25)]
    [TestCase("[1,2,3,4]", 1, 55)]
    [TestCase("[1,1,1]", 3, 3)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.MinPartitionScore(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
