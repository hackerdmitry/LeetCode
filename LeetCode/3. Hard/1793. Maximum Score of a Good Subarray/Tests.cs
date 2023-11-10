using NUnit.Framework;

namespace LeetCode._3._Hard._1793._Maximum_Score_of_a_Good_Subarray
{
    [TestFixture(TestName = "1793. Maximum Score of a Good Subarray")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] {1, 4, 3, 7, 4, 5}, 3, 15)]
        [TestCase(new[] {5, 5, 4, 5, 4, 1, 1, 1}, 0, 20)]
        [TestCase(new[] {6569, 9667, 3148, 7698, 1622, 2194, 793, 9041, 1670, 1872}, 5, 9732)]
        [TestCase(new[] {8182,1273,9847,6230,52,1467,6062,726,4852,4507,2460,2041,500,1025,5524}, 8, 9014)]
        [TestCase(new[] {5}, 0, 5)]
        public void Test(int[] input1, int input2, int output)
        {
            var solution = new Solution();
            var actual = solution.MaximumScore(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}
