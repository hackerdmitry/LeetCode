using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._2._Middle._2265._Count_Nodes_Equal_to_Average_of_Subtree;

[TestFixture(TestName = "2265. Count Nodes Equal to Average of Subtree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, int output)
    {
        var solution = new Solution();
        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.AverageOfSubtree(treeRoot);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {4, 8, 5, 0, 1, null, 6},
            5
        };
        yield return new object[]
        {
            new int?[] {1},
            1
        };
    }
}