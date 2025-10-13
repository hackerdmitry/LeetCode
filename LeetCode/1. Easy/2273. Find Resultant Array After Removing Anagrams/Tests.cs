using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2273._Find_Resultant_Array_After_Removing_Anagrams;

[TestFixture(TestName = "2273. Find Resultant Array After Removing Anagrams")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"abba\",\"baba\",\"bbaa\",\"cd\",\"cd\"]", "[\"abba\",\"cd\"]")]
    [TestCase("[\"a\",\"b\",\"c\",\"d\",\"e\"]", "[\"a\",\"b\",\"c\",\"d\",\"e\"]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveAnagrams(input.ParseStringArray());
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
