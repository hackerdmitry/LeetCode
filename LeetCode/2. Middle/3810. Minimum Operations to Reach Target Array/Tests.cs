using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3810._Minimum_Operations_to_Reach_Target_Array;

[TestFixture(TestName = "3810. Minimum Operations to Reach Target Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", "[2,1,3]", 2)]
    [TestCase("[4,1,4]", "[5,1,4]", 1)]
    [TestCase("[7,3,7]", "[5,5,9]", 2)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
