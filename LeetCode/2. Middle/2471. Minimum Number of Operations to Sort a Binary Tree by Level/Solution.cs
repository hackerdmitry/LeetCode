using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2471._Minimum_Number_of_Operations_to_Sort_a_Binary_Tree_by_Level;

public class Solution
{
    private readonly List<TreeNode> list1 = new(100_000);
    private readonly List<TreeNode> list2 = new(100_000);

    public int MinimumOperations(TreeNode root)
    {
        list2.Add(root);

        var result = 0;

        while (true)
        {
            MoveToList1();
            FillList2Children();
            if (list2.Count == 0)
                break;
            result += CountMinOperationsToSort(list2);
        }

        return result;
    }

    private void FillList2Children()
    {
        foreach (var node in list1)
        {
            if (node.left != null)
                list2.Add(node.left);
            if (node.right != null)
                list2.Add(node.right);
        }
    }

    private void MoveToList1()
    {
        list1.Clear();
        list1.AddRange(list2);
        list2.Clear();
    }

    private int CountMinOperationsToSort(List<TreeNode> nodes)
    {
        var checkedNodes = new bool[nodes.Count];
        var sortedNodesIndexes = nodes.OrderBy(x => x.val).Select((x, i) => (x, i)).ToDictionary(x => x.x.val, x => x.i);
        var result = 0;

        for (var i = 0; i < nodes.Count; i++)
            if (!checkedNodes[i])
                result += CountCircle(checkedNodes, nodes, sortedNodesIndexes, i) - 1;

        return result;
    }

    private int CountCircle(bool[] checkedNodes, List<TreeNode> nodes, Dictionary<int, int> sortedNodesIndexes, int startIndex)
    {
        var count = 0;
        var index = startIndex;
        while (!checkedNodes[index])
        {
            checkedNodes[index] = true;
            index = sortedNodesIndexes[nodes[index].val];
            count++;
        }

        return count;
    }
}
