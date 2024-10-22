using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2583._Kth_Largest_Sum_in_a_Binary_Tree;

[TestFixture(TestName = "2583. Kth Largest Sum in a Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,8,9,2,1,3,7,4,6]", 2, 13)]
    [TestCase("[1,2,null,3]", 1, 3)]
    [TestCase("[1,2,null,3]", 3, 1)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.KthLargestLevelSum(input1.ParseNullIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}