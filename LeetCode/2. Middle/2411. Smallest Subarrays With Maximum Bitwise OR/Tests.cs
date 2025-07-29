using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2411._Smallest_Subarrays_With_Maximum_Bitwise_OR;

[TestFixture(TestName = "2411. Smallest Subarrays With Maximum Bitwise OR")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0]", "[1]")]
    [TestCase("[0,0]", "[1,1]")]
    [TestCase("[4,0,5,6,3,2]", "[4,3,2,2,1,1]")]
    [TestCase("[1,0,2,1,3]", "[3,3,2,2,1]")]
    [TestCase("[1,2]", "[2,1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SmallestSubarrays(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
