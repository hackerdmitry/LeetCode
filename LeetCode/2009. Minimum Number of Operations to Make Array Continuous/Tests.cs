using NUnit.Framework;

namespace LeetCode._2009._Minimum_Number_of_Operations_to_Make_Array_Continuous
{
    [TestFixture(TestName = "2009. Minimum Number of Operations to Make Array Continuous")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[]{4,2,5,3}, 0)]
        [TestCase(new[]{1,2,3,5,6}, 1)]
        [TestCase(new[]{1,10,100,1000}, 3)]
        [TestCase(new[]{8,5,9,9,8,4}, 2)]
        [TestCase(new[]{1,1,1,1}, 3)]
        public void Test(int[] input, int output)
        {
            var solution = new Solution();
            var actual = solution.MinOperations(input);
            Assert.AreEqual(output, actual);
        }
    }
}