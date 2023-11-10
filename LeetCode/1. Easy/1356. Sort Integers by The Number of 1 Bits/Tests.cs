using NUnit.Framework;

namespace LeetCode._1356._Sort_Integers_by_The_Number_of_1_Bits
{
    [TestFixture(TestName = "1356. Sort Integers by The Number of 1 Bits")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[]{0,1,2,3,4,5,6,7,8}, new[]{0,1,2,4,8,3,5,6,7})]
        [TestCase(new[]{1024,512,256,128,64,32,16,8,4,2,1}, new[]{1,2,4,8,16,32,64,128,256,512,1024})]
        public void Test(int[] input, int[] output)
        {
            var solution = new Solution();
            var actual = solution.SortByBits(input);
            Assert.AreEqual(output, actual);
        }
    }
}