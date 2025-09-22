using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3005._Count_Elements_With_Maximum_Frequency;

[TestFixture(TestName = "3005. Count Elements With Maximum Frequency")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,2,3,1,4]", 4)]
    [TestCase("[1,2,3,4,5]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxFrequencyElements(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
