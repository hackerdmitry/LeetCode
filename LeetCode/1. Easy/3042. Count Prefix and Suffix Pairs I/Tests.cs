using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3042._Count_Prefix_and_Suffix_Pairs_I;

[TestFixture(TestName = "3042. Count Prefix and Suffix Pairs I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"a\",\"aba\",\"ababa\",\"aa\"]", 4)]
    [TestCase("[\"pa\",\"papa\",\"ma\",\"mama\"]", 2)]
    [TestCase("[\"abab\",\"ab\"]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountPrefixSuffixPairs(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
