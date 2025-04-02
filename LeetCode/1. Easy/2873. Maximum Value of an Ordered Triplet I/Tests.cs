using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2873._Maximum_Value_of_an_Ordered_Triplet_I;

[TestFixture(TestName = "2873. Maximum Value of an Ordered Triplet I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[6,11,12,12,7,9,2,11,12,4,19,14,16,8,16]", 190)]
    [TestCase("[10,5,20,11,1,15]", 285)]
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
