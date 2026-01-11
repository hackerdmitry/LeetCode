using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._206._Reverse_Linked_List;

[TestFixture(TestName = "206. Reverse Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2]", "[2,1]")]
    [TestCase("[1,2,3,4,5]", "[5,4,3,2,1]")]
    [TestCase("[]", "[]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseList(input.ParseIntArray()).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
