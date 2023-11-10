using NUnit.Framework;

namespace LeetCode._3._Hard._1220._Count_Vowels_Permutation
{
    [TestFixture(TestName = "1220. Count Vowels Permutation")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(1, 5)]
        [TestCase(2, 10)]
        [TestCase(5, 68)]
        [TestCase(144, 18208803)]
        public void Test(int input, int output)
        {
            var solution = new Solution();
            var actual = solution.CountVowelPermutation(input);
            Assert.AreEqual(output, actual);
        }
    }
}
