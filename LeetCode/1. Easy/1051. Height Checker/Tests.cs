using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1051._Height_Checker;

[TestFixture(TestName = "1051. Height Checker")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,4,2,1,3]", 3)]
    [TestCase("[5,1,2,3,4]", 5)]
    [TestCase("[1,2,3,4,5]", 0)]
    [TestCase("[2,1,2,1,1,2,2,1]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.HeightChecker(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
