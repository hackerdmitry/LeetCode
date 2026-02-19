using NUnit.Framework;

namespace LeetCode._1._Easy._696._Count_Binary_Substrings;

[TestFixture(TestName = "696. Count Binary Substrings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("00110011", 6)]
    [TestCase("10101", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountBinarySubstrings(input);
        Assert.AreEqual(output, actual);
    }
}
