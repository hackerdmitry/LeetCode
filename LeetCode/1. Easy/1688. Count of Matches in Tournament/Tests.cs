using NUnit.Framework;

namespace LeetCode._1._Easy._1688._Count_of_Matches_in_Tournament;

[TestFixture(TestName = "1688. Count of Matches in Tournament")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(7, 6)]
    [TestCase(14, 13)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfMatches(input);
        Assert.AreEqual(output, actual);
    }
}
