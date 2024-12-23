using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2471._Minimum_Number_of_Operations_to_Sort_a_Binary_Tree_by_Level;

[TestFixture(TestName = "2471. Minimum Number of Operations to Sort a Binary Tree by Level")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,4,3,7,6,8,5,null,null,null,null,9,null,10]", 3)]
    [TestCase("[1,3,2,7,6,5,4]", 3)]
    [TestCase("[1,2,3,4,5,6]", 0)]
    [TestCase("[1,2,3,5,4,7,6]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumOperations(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
