using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3068._Find_the_Maximum_Sum_of_Node_Values;

[TestFixture(TestName = "3068. Find the Maximum Sum of Node Values")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,1]", 3, "[[0,1],[0,2]]", 6)]
    [TestCase("[2,3]", 7, "[[0,1]]", 9)]
    [TestCase("[7,7,7,7,7,7]", 3, "[[0,1],[0,2],[0,3],[0,4],[0,5]]", 42)]
    [TestCase("[24,78,1,97,44]", 6, "[[0,2],[1,2],[4,2],[3,4]]", 260)]
    [TestCase("[0,92,56,3,34,23,56]", 7, "[[2,6],[4,1],[5,0],[1,0],[3,1],[6,3]]", 288)]
    [TestCase("[78,43,92,97,95,94]", 6, "[[1,2],[3,0],[4,0],[0,1],[1,5]]", 507)]
    public void Test(string input1, int input2, string input3, long output)
    {
        var solution = new Solution();
        var actual = solution.MaximumValueSum(input1.ParseIntArray(), input2, input3.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}