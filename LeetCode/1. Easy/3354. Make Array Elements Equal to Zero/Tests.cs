using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3354._Make_Array_Elements_Equal_to_Zero;

[TestFixture(TestName = "3354. Make Array Elements Equal to Zero")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,2,0,3]", 2)]
    [TestCase("[2,3,4,0,4,1,0]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountValidSelections(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
