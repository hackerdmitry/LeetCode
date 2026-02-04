using System.Collections.Generic;

namespace LeetCode._2._Middle._138._Copy_List_with_Random_Pointer;

public class Solution
{
    public Node CopyRandomList(Node head)
    {
        if (head == null)
            return null;

        var dict = new Dictionary<Node, Node>();
        return CopyNode(head);

        Node CopyNode(Node node)
        {
            if (node == null)
                return null;
            if (dict.ContainsKey(node))
                return dict[node];

            var newNode = new Node(node.val);
            dict[node] = newNode;

            newNode.next = CopyNode(node.next);
            newNode.random = CopyNode(node.random);

            return newNode;
        }
    }
}
