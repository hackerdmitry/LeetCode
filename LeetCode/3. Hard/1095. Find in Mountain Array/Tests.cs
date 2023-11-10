using NUnit.Framework;

namespace LeetCode._1095._Find_in_Mountain_Array
{
    [TestFixture(TestName = "1095. Find in Mountain Array")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 3, 1 }, 3, 2)]
        [TestCase(new[] { 0, 1, 2, 4, 2, 1 }, 3, -1)]
        [TestCase(new[] { 0, 1, 2, 3 }, 3, 3)]
        [TestCase(new[] { 3, 2, 1, 0 }, 3, 0)]
        [TestCase(new[] { 1, 5, 2 }, 2, 2)]
        public void Test(int[] input1, int input2, int output)
        {
            var solution = new Solution();
            var actual = solution.FindInMountainArray(input2, new MountainArray(input1));
            Assert.AreEqual(output, actual);
        }
    }
}