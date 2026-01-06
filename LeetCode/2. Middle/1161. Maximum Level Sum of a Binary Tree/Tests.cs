using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1161._Maximum_Level_Sum_of_a_Binary_Tree;

[TestFixture(TestName = "1161. Maximum Level Sum of a Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,7,0,7,-8,null,null]", 2)]
    [TestCase("[989,null,10250,98693,-89388,null,null,null,-32127]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxLevelSum(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
