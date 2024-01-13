using NUnit.Framework;

namespace LeetCode._2._Middle._1347._Minimum_Number_of_Steps_to_Make_Two_Strings_Anagram;

[TestFixture(TestName = "1347. Minimum Number of Steps to Make Two Strings Anagram")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("bab", "aba", 1)]
    [TestCase("leetcode", "practice", 5)]
    [TestCase("anagram", "mangaar", 0)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinSteps(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
