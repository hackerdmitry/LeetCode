using NUnit.Framework;

namespace LeetCode._2._Middle._1361._Validate_Binary_Tree_Nodes
{
    [TestFixture(TestName = "1361. Validate Binary Tree Nodes")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(4, new[] { 1, -1, 3, -1 }, new[] { 2, -1, -1, -1 }, true)]
        [TestCase(4, new[] { 1, -1, 3, -1 }, new[] { 2, 3, -1, -1 }, false)]
        [TestCase(2, new[] { 1, 0 }, new[] { -1, -1 }, false)]
        [TestCase(6, new[] { 1, -1, -1, 4, -1, -1 }, new[] { 2, -1, -1, 5, -1, -1 }, false)]
        [TestCase(4, new[] { 3, -1, 1, -1 }, new[] { -1, -1, 0, -1 }, true)]
        [TestCase(5, new[] { 2, 2, -1, 1, 3 }, new[] { 2, 2, 1, 2, 1 }, false)]
        [TestCase(3, new[] { 1, -1, -1 }, new[] { -1, -1, 1 }, false)]
        [TestCase(3, new[] { -1, 2, -1 }, new[] { -1, -1, -1 }, false)]
        public void Test(int input1, int[] input2, int[] input3, bool output)
        {
            var solution = new Solution();
            var actual = solution.ValidateBinaryTreeNodes(input1, input2, input3);
            Assert.AreEqual(output, actual);
        }
    }
}