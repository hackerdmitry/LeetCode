using NUnit.Framework;

namespace LeetCode._1._Easy._1399._Count_Largest_Group;

[TestFixture(TestName = "1399. Count Largest Group")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(13, 4)]
    [TestCase(2, 2)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountLargestGroup(input);
        Assert.AreEqual(output, actual);
    }
}
