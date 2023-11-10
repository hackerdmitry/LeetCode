using NUnit.Framework;

namespace LeetCode._2433._Find_The_Original_Array_of_Prefix_Xor
{
    [TestFixture(TestName = "2433. Find The Original Array of Prefix Xor")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[]{5,2,0,3,1}, new[]{5,7,2,3,2})]
        [TestCase(new[]{13}, new[]{13})]
        public void Test(int[] input, int[] output)
        {
            var solution = new Solution();
            var actual = solution.FindArray(input);
            Assert.AreEqual(output, actual);
        }
    }
}