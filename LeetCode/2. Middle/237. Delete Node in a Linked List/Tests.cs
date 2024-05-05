using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._237._Delete_Node_in_a_Linked_List;

[TestFixture(TestName = "237. Delete Node in a Linked List")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {4, 5, 1, 9}, 5, new[] {4, 1, 9})]
    [TestCase(new[] {4, 5, 1, 9}, 1, new[] {4, 5, 9})]
    public void Test(int[] input1, int input2, int[] output)
    {
        var solution = new Solution();
        var head = ListNode.CreateFromArray(input1);
        var node = head;
        while (node.val != input2)
            node = node.next;
        solution.DeleteNode(node);
        var actual = head.ToArray();
        actual.WriteLine("actual");
        output.WriteLine("expected");
        Assert.AreEqual(output, actual);
    }
}