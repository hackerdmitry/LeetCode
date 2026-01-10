using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._283._Move_Zeroes;

[TestFixture(TestName = "283. Move Zeroes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,0,3,12]", "[1,3,12,0,0]")]
    [TestCase("[0]", "[0]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = input.ParseIntArray();
        solution.MoveZeroes(actual);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
