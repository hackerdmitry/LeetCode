using System;
using NUnit.Framework;

namespace LeetCode._2._Middle._2901._Longest_Unequal_Adjacent_Groups_Subsequence_II;

[TestFixture(TestName = "2901. Longest Unequal Adjacent Groups Subsequence II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{"bab","dab","cab"}, new[]{1,2,2}, new[]{"bab","dab"})]
    [TestCase(new[]{"a","b","c","d"}, new[]{1,2,3,4}, new[]{"a","b","c","d"})]
    [TestCase(new[]{"a","b","c","d"}, new[]{1,2,3,3}, new[]{"a","b","c"})]
    [TestCase(new[]{"abbbb"}, new[]{1}, new[]{"abbbb"})]
    [TestCase(new[]{"ccd","bb","ccc"}, new[]{1,1,2}, new[]{"ccd","ccc"})]
    [TestCase(new[]{"bdb","aaa","ada"}, new[]{2,1,3}, new[]{"aaa","ada"})]
    [TestCase(new[]{"dcaacc","da","ddcbd","dd"}, new[]{2,3,1,4}, new[]{"da","dd"})]
    [TestCase(new[]{"aab","cab","ba","dba","daa","bca"}, new[]{4,3,4,6,4,3}, new[]{"aab,cab"})]
    public void Test(string[] input1, int[] input2, string[] output)
    {
        var solution = new Solution();
        Console.WriteLine($"output: [{string.Join(',', output)}]");
        var actual = solution.GetWordsInLongestSubsequence(input1, input2);
        Console.WriteLine($"actual: [{string.Join(',', actual)}]");
        Assert.AreEqual(output, actual);
    }
}
