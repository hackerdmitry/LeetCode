using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1679._Max_Number_of_K_Sum_Pairs;

[TestFixture(TestName = "1679. Max Number of K-Sum Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4]", 5, 2)]
    [TestCase("[3,1,3,4,3]", 6, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxOperations(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
