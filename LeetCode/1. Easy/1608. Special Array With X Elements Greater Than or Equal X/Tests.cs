using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1608._Special_Array_With_X_Elements_Greater_Than_or_Equal_X;

[TestFixture(TestName = "1608. Special Array With X Elements Greater Than or Equal X")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,5]", 2)]
    [TestCase("[0,0]", -1)]
    [TestCase("[0,4,3,0,4]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SpecialArray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
