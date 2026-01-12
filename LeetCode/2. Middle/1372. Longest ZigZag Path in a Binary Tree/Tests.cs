using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1372._Longest_ZigZag_Path_in_a_Binary_Tree;

[TestFixture(TestName = "1372. Longest ZigZag Path in a Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,null,1,1,1,null,null,1,1,null,1,null,null,null,1]", 3)]
    [TestCase("[1,1,1,null,1,null,null,1,1,null,1]", 4)]
    [TestCase("[1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestZigZag(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
