using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._827._Making_A_Large_Island;

[TestFixture(TestName = "827. Making A Large Island")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,0,0,0,0,0],[0,1,1,1,1,0,0],[0,1,0,0,1,0,0],[1,0,1,0,1,0,0],[0,1,0,0,1,0,0],[0,1,0,0,1,0,0],[0,1,1,1,1,0,0]]", 18)]
    [TestCase("[[1,0],[0,1]]", 3)]
    [TestCase("[[1,1],[1,0]]", 4)]
    [TestCase("[[1,1],[1,1]]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LargestIsland(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
