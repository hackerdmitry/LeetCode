using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._328._Odd_Even_Linked_List;

[TestFixture(TestName = "328. Odd Even Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", "[1,3,5,2,4]")]
    [TestCase("[2,1,3,5,6,4,7]", "[2,3,6,7,1,5,4]")]
    [TestCase("[1,2,3,4,5,6,7,8]", "[1,3,5,7,2,4,6,8]")]
    [TestCase("[1,2]", "[1,2]")]
    [TestCase("[]", "[]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.OddEvenList(input.ParseIntArray()).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
