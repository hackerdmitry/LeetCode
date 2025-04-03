using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2874._Maximum_Value_of_an_Ordered_Triplet_II;

[TestFixture(TestName = "2874. Maximum Value of an Ordered Triplet II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[12,6,1,2,7]", 77)]
    [TestCase("[1,10,3,4,19]", 133)]
    [TestCase("[1,2,3]", 0)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MaximumTripletValue(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
