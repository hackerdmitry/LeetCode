using NUnit.Framework;

namespace LeetCode._2._Middle._1980._Find_Unique_Binary_String;

[TestFixture(TestName = "1980. Find Unique Binary String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"01","10"}, "00")]
    [TestCase(new[]{"00","01"}, "10")]
    [TestCase(new[]{"111","011","001"}, "000")]
    public void Test(string[] input, string output)
    {
        var solution = new Solution();
        var actual = solution.FindDifferentBinaryString(input);
        Assert.AreEqual(output, actual);
    }
}
