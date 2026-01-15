using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._162._Find_Peak_Element;

[TestFixture(TestName = "162. Find Peak Element")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2]", 1)]
    [TestCase("[1,2,3,1]", 2)]
    [TestCase("[1,2,1,3,5,6,4]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindPeakElement(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
