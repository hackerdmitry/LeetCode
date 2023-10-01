using NUnit.Framework;

namespace LeetCode._896._Monotonic_Array
{
    [TestFixture(TestName = "896. Monotonic Array")]
    public class Tests
    {
        [TestCase(new[] {1, 2, 2, 3}, true)]
        [TestCase(new[] {6, 5, 4, 4}, true)]
        [TestCase(new[] {1, 3, 2}, false)]
        public void Test(int[] input, bool output)
        {
            var solution = new Solution();
            var actual = solution.IsMonotonic(input);
            Assert.AreEqual(output, actual);
        }
    }
}