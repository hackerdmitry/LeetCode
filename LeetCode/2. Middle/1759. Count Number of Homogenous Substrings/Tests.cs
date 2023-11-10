using NUnit.Framework;

namespace LeetCode._2._Middle._1759._Count_Number_of_Homogenous_Substrings;

[TestFixture(TestName = "1759. Count Number of Homogenous Substrings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abbcccaa", 13)]
    [TestCase("xy", 2)]
    [TestCase("zzzzz", 15)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountHomogenous(input);
        Assert.AreEqual(output, actual);
    }
}
