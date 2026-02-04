using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._141._Linked_List_Cycle;

[TestFixture(TestName = "141. Linked List Cycle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,2,0,-4]", 1, true)]
    [TestCase("[1,2]", 0, true)]
    [TestCase("[1]", -1, false)]
    public void Test(string input1, int input2, bool output)
    {
        var solution = new Solution();
        var head = ListNode.CreateFromArray(input1.ParseIntArray());
        ConnectTailToNode(head, input2);
        var actual = solution.HasCycle(head);
        Assert.AreEqual(output, actual);
    }

    private void ConnectTailToNode(ListNode node, int pos)
    {
        if (pos == -1)
            return;

        var connectNode = node;
        while (node.next != null)
        {
            if (pos-- == 0)
                connectNode = node;
            node = node.next;
        }

        node.next = connectNode;
    }
}
