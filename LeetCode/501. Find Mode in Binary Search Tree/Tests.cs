using System.Collections;
using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._501._Find_Mode_in_Binary_Search_Tree
{
    [TestFixture(TestName = "501. Find Mode in Binary Search Tree")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCaseSource(nameof(Input))]
        public void Test(int?[] input, int[] output)
        {
            var solution = new Solution();

            var treeRoot = TreeNode.CreateFromArray(input);
            var actual = solution.FindMode(treeRoot);

            Assert.AreEqual(output, actual);
        }

        private static IEnumerable Input()
        {
            yield return new object[]
            {
                new int?[]{1,null,2,2},
                new[]{2}
            };
            yield return new object[]
            {
                new int?[]{0},
                new[]{0}
            };
        }
    }
}