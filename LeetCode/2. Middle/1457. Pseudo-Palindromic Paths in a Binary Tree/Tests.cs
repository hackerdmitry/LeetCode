using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._2._Middle._1457._Pseudo_Palindromic_Paths_in_a_Binary_Tree;

[TestFixture(TestName = "1457. Pseudo-Palindromic Paths in a Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, int output)
    {
        var solution = new Solution();
        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.PseudoPalindromicPaths(treeRoot);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {2, 3, 1, 3, 1, null, 1},
            2
        };
        yield return new object[]
        {
            new int?[] {2, 1, 1, 1, 3, null, null, null, null, null, 1},
            1
        };
        yield return new object[]
        {
            new int?[] {9},
            1
        };
        yield return new object[]
        {
            new int?[] {8, 8, null, 7, 7, null, null, 2, 4, null, 8, null, 7, null, 1},
            2
        };
    }
}