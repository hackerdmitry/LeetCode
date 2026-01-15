using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2462._Total_Cost_to_Hire_K_Workers;

[TestFixture(TestName = "2462. Total Cost to Hire K Workers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[31,25,72,79,74,65,84,91,18,59,27,9,81,33,17,58]", 11, 2, 423)]
    [TestCase("[17,12,10,2,7,2,11,20,8]", 3, 4, 11)]
    [TestCase("[1,2,4,1]", 3, 3, 4)]
    public void Test(string input1, int input2, int input3, long output)
    {
        var solution = new Solution();
        var actual = solution.TotalCost(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
