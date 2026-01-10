using NUnit.Framework;

namespace LeetCode._2._Middle._1456._Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length;

[TestFixture(TestName = "1456. Maximum Number of Vowels in a Substring of Given Length")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abciiidef", 3, 3)]
    [TestCase("aeiou", 2, 2)]
    [TestCase("leetcode", 3, 2)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxVowels(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
