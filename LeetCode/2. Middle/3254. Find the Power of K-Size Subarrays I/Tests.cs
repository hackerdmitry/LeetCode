using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3254._Find_the_Power_of_K_Size_Subarrays_I;

[TestFixture(TestName = "3254. Find the Power of K-Size Subarrays I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,3,2,5]", 3, "[3,4,-1,-1,-1]")]
    [TestCase("[2,2,2,2,2]", 4, "[-1,-1]")]
    [TestCase("[3,2,3,2,3,2]", 2, "[-1,3,-1,3,-1]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ResultsArray(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}