using System.Collections;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace LeetCode._2._Middle._456._132_Pattern
{
    [TestFixture(TestName = "456. 132 Pattern")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] {1, 2, 3, 4}, false)]
        [TestCase(new[] {3, 1, 4, 2}, true)]
        [TestCase(new[] {-1, 3, 2, 0}, true)]
        [TestCase(new[] {1, 1, 2, 1, 1, 1, 1, 1}, false)]
        [TestCase(new[] {1, 1, 7, 1, 1, 1, 2, 1}, true)]
        [TestCase(new[] {3, 1, 4, 0, 2}, true)]
        [TestCase(new[] {3, 1, 4, 0, 1}, false)]
        [TestCase(new[] {3, 2, 4, 0, 2, 1}, true)]
        [TestCase(new[] {1, 3, 2, 4, 3, 5, 4, 6, 5, 7, 6, 8, 9}, true)]
        [TestCase(new[] {1, 3, 2, 4, 3, 5, 4, 6, 5, 7, 6, 8, 2}, true)]
        [TestCase(new[] {14, 16, 12, 14, 10, 12, 8, 10, 6, 8, 4, 6, 16}, false)]
        [TestCase(new[] {14, 16, 12, 14, 10, 12, 8, 10, 6, 8, 4, 6, 15}, true)]
        [TestCase(new[] {14, 16, 12, 14, 10, 12, 8, 10, 6, 8, 4, 6, 11}, true)]
        [TestCase(new[] {14, 16, 12, 14, 10, 12, 8, 10, 6, 8, 4, 6, 5}, true)]
        [TestCaseSource(nameof(LongInput))]
        public void Test(int[] input, bool output)
        {
            var solution = new Solution();
            var actual = solution.Find132pattern(input);
            Assert.AreEqual(output, actual);
        }

        private static IEnumerable LongInput()
        {
            var sr = new StreamReader("./456. 132 Pattern/LongInput.txt");
            var input = sr.ReadToEnd().Split(",").Select(int.Parse).ToArray();
            yield return new object[] {input, false};
        }
    }
}