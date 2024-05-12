using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._2._Middle._2487._Remove_Nodes_From_Linked_List;

[TestFixture(TestName = "2487. Remove Nodes From Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {5, 2, 13, 3, 8}, new[] {13, 8})]
    [TestCase(new[] {1, 1, 1, 1}, new[] {1, 1, 1, 1})]
    public void Test(int[] input, int[] output)
    {
        var solution = new Solution();
        var actual = solution.RemoveNodes(input).ToArray();
        Assert.AreEqual(output, actual);
    }
}