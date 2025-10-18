using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3397._Maximum_Number_of_Distinct_Elements_After_Operations;

[TestFixture(TestName = "3397. Maximum Number of Distinct Elements After Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,4,4,4]", 1, 3)]
    [TestCase("[1,2,2,3,3,4]", 2, 6)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDistinctElements(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}