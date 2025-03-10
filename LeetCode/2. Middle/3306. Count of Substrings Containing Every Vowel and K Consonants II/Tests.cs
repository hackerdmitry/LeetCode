using NUnit.Framework;

namespace LeetCode._2._Middle._3306._Count_of_Substrings_Containing_Every_Vowel_and_K_Consonants_II;

[TestFixture(TestName = "3306. Count of Substrings Containing Every Vowel and K Consonants II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("iqeaouqi", 2, 3)]
    [TestCase("ieaouqqieaouqq", 1, 3)]
    [TestCase("aeioqq", 1, 0)]
    [TestCase("aeiou", 0, 1)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.CountOfSubstrings(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
