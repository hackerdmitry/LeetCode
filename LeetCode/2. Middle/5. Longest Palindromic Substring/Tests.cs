using NUnit.Framework;

namespace LeetCode._2._Middle._5._Longest_Palindromic_Substring
{
    [TestFixture(TestName = "5. Longest Palindromic Substring")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        public void Test(string input, string output)
        {
            var solution = new Solution();
            var actual = solution.LongestPalindrome(input);
            Assert.AreEqual(output, actual);
        }
    }
}