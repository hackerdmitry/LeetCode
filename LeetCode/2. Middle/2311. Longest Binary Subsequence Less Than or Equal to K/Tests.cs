using NUnit.Framework;

namespace LeetCode._2._Middle._2311._Longest_Binary_Subsequence_Less_Than_or_Equal_to_K;

[TestFixture(TestName = "2311. Longest Binary Subsequence Less Than or Equal to K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("100110111111000000010011101000111011000001000111010001010111100001111110110010100011100100111000011011000000100001011000000100110110001101011010011", 522399436, 92)]
    [TestCase("1001010", 5, 5)]
    [TestCase("00101001", 1, 6)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestSubsequence(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
