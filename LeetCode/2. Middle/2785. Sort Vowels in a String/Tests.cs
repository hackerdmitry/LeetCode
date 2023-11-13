using NUnit.Framework;

namespace LeetCode._2._Middle._2785._Sort_Vowels_in_a_String;

[TestFixture(TestName = "2785. Sort Vowels in a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("lEetcOde", "lEOtcede")]
    [TestCase("lYmpH", "lYmpH")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SortVowels(input);
        Assert.AreEqual(output, actual);
    }
}
