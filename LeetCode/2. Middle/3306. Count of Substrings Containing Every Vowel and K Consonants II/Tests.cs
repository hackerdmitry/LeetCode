using System.Text;
using NUnit.Framework;

namespace LeetCode._2._Middle._3306._Count_of_Substrings_Containing_Every_Vowel_and_K_Consonants_II;

[TestFixture(TestName = "3306. Count of Substrings Containing Every Vowel and K Consonants II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aaaqeiouqaaa", 2, 15)]
    [TestCase("aeeieoua", 0, 5)]
    [TestCase("ieaouqqqieaouqq", 1, 3)]
    [TestCase("qaeiou", 0, 1)]
    [TestCase("aeiouqaeiou", 0, 2)]
    [TestCase("aeiou", 0, 1)]
    [TestCase("auaqeiouqaua", 2, 15)]
    [TestCase("auaqueioqauaq", 2, 17)]
    [TestCase("aaaqeiouqeee", 2, 12)]
    [TestCase("iqeaouqi", 2, 3)]
    [TestCase("aeioqq", 1, 0)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.CountOfSubstrings(input1, input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [Test]
    public void BitTest()
    {
        var sb = new StringBuilder(100_000)
            .Append('a', 49_997)
            .Append('q')
            .Append('e')
            .Append('i')
            .Append('o')
            .Append('u')
            .Append('q')
            .Append('a', 49_997);
        Test(sb.ToString(), 2, 2_499_800_003L);
    }
}
