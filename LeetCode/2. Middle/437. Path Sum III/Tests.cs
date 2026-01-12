using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._437._Path_Sum_III;

[TestFixture(TestName = "437. Path Sum III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[10,5,-3,3,2,null,11,3,-2,null,1]", 8, 3)]
    [TestCase("[5,4,8,11,null,13,4,7,2,null,null,5,1]", 22, 3)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.PathSum(input1.ParseNullIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
