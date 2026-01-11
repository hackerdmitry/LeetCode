using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._85._Maximal_Rectangle;

[TestFixture(TestName = "85. Maximal Rectangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[['1','0','1','0','0'],['1','0','1','1','1'],['1','1','1','1','1'],['1','0','0','1','0']]", 6)]
    [TestCase("[['0']]", 0)]
    [TestCase("[['1']]", 1)]
    [TestCase("[['1','0','0','0','1','0','0'],['1','0','0','0','1','1','1'],['1','1','1','1','1','1','1'],['1','0','0','0','0','1','0']]", 7)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximalRectangle(input.ParseCharArray2d());
        Assert.AreEqual(output, actual);
    }
}
