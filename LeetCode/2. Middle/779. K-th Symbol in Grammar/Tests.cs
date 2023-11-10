using NUnit.Framework;

namespace LeetCode._779._K_th_Symbol_in_Grammar
{
    [TestFixture(TestName = "779. K-th Symbol in Grammar")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(1, 1, 0)]
        [TestCase(2, 1, 0)]
        [TestCase(2, 2, 1)]
        public void Test(int input1, int input2, int output)
        {
            var solution = new Solution();
            var actual = solution.KthGrammar(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}