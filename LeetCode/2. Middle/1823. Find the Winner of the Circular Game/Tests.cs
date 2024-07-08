using NUnit.Framework;

namespace LeetCode._2._Middle._1823._Find_the_Winner_of_the_Circular_Game;

[TestFixture(TestName = "1823. Find the Winner of the Circular Game")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, 2, 3)]
    [TestCase(5, 3, 4)]
    [TestCase(6, 5, 1)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindTheWinner(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
