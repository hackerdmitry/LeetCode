using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._717._1_bit_and_2_bit_Characters;

[TestFixture(TestName = "717. 1-bit and 2-bit Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,0]", true)]
    [TestCase("[1,1,1,0]", false)]
    [TestCase("[1,1,0,0]", true)]
    [TestCase("[1,0,0,0]", true)]
    [TestCase("[1,1,0]", true)]
    [TestCase("[0]", true)]
    [TestCase("[1,0]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsOneBitCharacter(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
