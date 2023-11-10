using NUnit.Framework;

namespace LeetCode._1._Easy._119._Pascal_s_Triangle_II
{
    [TestFixture(TestName = "119. Pascal's Triangle II")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(3, new[]{1,3,3,1})]
        [TestCase(0, new[]{1})]
        [TestCase(1, new[]{1,1})]
        public void Test(int input, int[] output)
        {
            var solution = new Solution();
            var actual = solution.GetRow(input);
            Assert.AreEqual(output, actual);
        }
    }
}