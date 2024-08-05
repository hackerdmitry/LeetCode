using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2053._Kth_Distinct_String_in_an_Array;

[TestFixture(TestName = "2053. Kth Distinct String in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"d\",\"b\",\"c\",\"b\",\"c\",\"a\"]", 2, "a")]
    [TestCase("[\"aaa\",\"aa\",\"a\"]", 1, "aaa")]
    [TestCase("[\"a\",\"b\",\"a\"]", 3, "")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.KthDistinct(input1.ParseStringArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
