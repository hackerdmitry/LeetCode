using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._101._Symmetric_Tree;

[TestFixture(TestName = "101. Symmetric Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, bool output)
    {
        var solution = new Solution();
        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.IsSymmetric(treeRoot);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {1, 2, 2, 3, 4, 4, 3},
            true,
        };
        yield return new object[]
        {
            new int?[] {1, 2, 2, null, 3, null, 3},
            false,
        };
        yield return new object[]
        {
            new int?[] {1, 0},
            false,
        };
        yield return new object[]
        {
            new int?[] {1, 2, 2, null, 3, 3},
            true,
        };
    }
}