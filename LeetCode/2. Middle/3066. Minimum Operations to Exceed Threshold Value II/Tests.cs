using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3066._Minimum_Operations_to_Exceed_Threshold_Value_II;

[TestFixture(TestName = "3066. Minimum Operations to Exceed Threshold Value II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[999999999,999999999,999999999]", 1000000000, 2)]
    [TestCase("[2,11,10,1,3]", 10, 2)]
    [TestCase("[1,1,2,4,9]", 20, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
