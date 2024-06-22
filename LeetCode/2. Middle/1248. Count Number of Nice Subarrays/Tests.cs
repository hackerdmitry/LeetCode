using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1248._Count_Number_of_Nice_Subarrays;

[TestFixture(TestName = "1248. Count Number of Nice Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,2,1,1]", 3, 2)]
    [TestCase("[2,4,6]", 1, 0)]
    [TestCase("[2,2,2,1,2,2,1,2,2,2]", 2, 16)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfSubarrays(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
