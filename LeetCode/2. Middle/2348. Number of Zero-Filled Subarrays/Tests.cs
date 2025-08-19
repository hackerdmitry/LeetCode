using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2348._Number_of_Zero_Filled_Subarrays;

[TestFixture(TestName = "2348. Number of Zero-Filled Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,0,0,2,0,0,4]", 6)]
    [TestCase("[0,0,0,2,0,0]", 9)]
    [TestCase("[2,10,2019]", 0)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.ZeroFilledSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
