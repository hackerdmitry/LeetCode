using NUnit.Framework;

namespace LeetCode._2._Middle._790._Domino_and_Tromino_Tiling;

[TestFixture(TestName = "790. Domino and Tromino Tiling")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 11)]
    [TestCase(3, 5)]
    [TestCase(2, 2)]
    [TestCase(1, 1)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumTilings(input);
        Assert.AreEqual(output, actual);
    }
}
