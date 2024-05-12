using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._2._Middle._2816._Double_a_Number_Represented_as_a_Linked_List;

[TestFixture(TestName = "2816. Double a Number Represented as a Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {1, 8, 9}, new[] {3, 7, 8})]
    [TestCase(new[] {9, 9, 9}, new[] {1, 9, 9, 8})]
    public void Test(int[] input, int[] output)
    {
        var solution = new Solution();
        var actual = solution.DoubleIt(input).ToArray();
        Assert.AreEqual(output, actual);
    }
}