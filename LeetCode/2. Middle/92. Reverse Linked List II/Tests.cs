using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._92._Reverse_Linked_List_II;

[TestFixture(TestName = "92. Reverse Linked List II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 2, 4, "[1,4,3,2,5]")]
    [TestCase("[1,2,3,4,5]", 1, 3, "[3,2,1,4,5]")]
    [TestCase("[5]", 1, 1, "[5]")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseBetween(input1.ParseIntArray(), input2, input3).ToArray();
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
