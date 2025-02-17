using NUnit.Framework;

namespace LeetCode._2._Middle._1079._Letter_Tile_Possibilities;

[TestFixture(TestName = "1079. Letter Tile Possibilities")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("AAB", 8)]
    [TestCase("AAABBC", 188)]
    [TestCase("ABCDEFG", 13699)]
    [TestCase("V", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumTilePossibilities(input);
        Assert.AreEqual(output, actual);
    }
}
