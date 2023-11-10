using System.Collections;
using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._2._Middle._515._Find_Largest_Value_in_Each_Tree_Row
{
    [TestFixture(TestName = "515. Find Largest Value in Each Tree Row")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCaseSource(nameof(Input))]
        public void Test(int?[] input, int[] output)
        {
            var treeRoot = TreeNode.CreateFromArray(input);
            var actual = new Solution().LargestValues(treeRoot);
            Assert.AreEqual(output, actual);
        }

        private static IEnumerable Input()
        {
            yield return new object[]
            {
                new int?[]{1,3,2,5,3,null,9},
                new[]{1,3,9}
            };
            yield return new object[]
            {
                new int?[]{1,2,3},
                new[]{1,3}
            };
        }
    }
}