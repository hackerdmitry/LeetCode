using System;
using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._94._Binary_Tree_Inorder_Traversal;

[TestFixture(TestName = "94. Binary Tree Inorder Traversal")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, int[] output)
    {
        var solution = new Solution();

        var treeRoot = TreeNode.CreateFromArray(input);
        Console.WriteLine("expected: " + string.Join(", ", output));
        var actual = solution.InorderTraversal(treeRoot);
        Console.WriteLine("actual: " + string.Join(", ", actual));

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {1, null, 2, 3},
            new[] {1, 3, 2}
        };
        yield return new object[]
        {
            Array.Empty<int?>(),
            Array.Empty<int>(),
        };
        yield return new object[]
        {
            new int?[] {1},
            new[] {1}
        };
        yield return new object[]
        {
            new int?[] {3, 1, 2},
            new[] {1, 3, 2}
        };
    }
}