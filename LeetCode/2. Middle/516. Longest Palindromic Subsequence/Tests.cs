using NUnit.Framework;

namespace LeetCode._2._Middle._516._Longest_Palindromic_Subsequence;

[TestFixture(TestName = "516. Longest Palindromic Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("bbbab", 4)]
    [TestCase("cbbd", 2)]
    [TestCase("cbbbab", 4)]
    [TestCase("cbbsbab", 5)]
    [TestCase("cbbbbab", 5)]
    [TestCase("a", 1)]
    [TestCase("euazbipzncptldueeuechubrcourfpftcebikrxhybkymimgvldiwqvkszfycvqyvtiwfckexmowcxztkfyzqovbtmzpxojfofbvwnncajvrvdbvjhcrameamcfmcoxryjukhpljwszknhiypvyskmsujkuggpztltpgoczafmfelahqwjbhxtjmebnymdyxoeodqmvkxittxjnlltmoobsgzdfhismogqfpfhvqnxeuosjqqalvwhsidgiavcatjjgeztrjuoixxxoznklcxolgpuktirmduxdywwlbikaqkqajzbsjvdgjcnbtfksqhquiwnwflkldgdrqrnwmshdpykicozfowmumzeuznolmgjlltypyufpzjpuvucmesnnrwppheizkapovoloneaxpfinaontwtdqsdvzmqlgkdxlbeguackbdkftzbnynmcejtwudocemcfnuzbttcoew", 159)]
    [TestCase("aaaaaa", 6)]
    [TestCase("qwertyuiopasdfghjklzxcvbnm", 1)]
    [TestCase("aiopahaa", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestPalindromeSubseq(input);
        Assert.AreEqual(output, actual);
    }
}
