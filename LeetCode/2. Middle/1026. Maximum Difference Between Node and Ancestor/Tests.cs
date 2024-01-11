using System.Collections;
using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._2._Middle._1026._Maximum_Difference_Between_Node_and_Ancestor;

[TestFixture(TestName = "1026. Maximum Difference Between Node and Ancestor")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, int output)
    {
        var solution = new Solution();

        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.MaxAncestorDiff(treeRoot);

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[]{8,3,10,1,6,null,14,null,null,4,7,13},
            7,
        };
        yield return new object[]
        {
            new int?[]{1,null,2,null,0,3},
            3,
        };
    }
}
