using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode._515._Find_Largest_Value_in_Each_Tree_Row
{
    [TestFixture(TestName = "515. Find Largest Value in Each Tree Row")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCaseSource(nameof(Input))]
        public void Test(int?[] input, int[] output)
        {
            var solution = new Solution();

            var index = 0;
            var treeRoot = input.Length > 0 && input[index].HasValue ? new TreeNode(input[index++].Value) : null;
            if (treeRoot != null)
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(treeRoot);
                while (queue.Count > 0 && input.Length > index)
                {
                    var left = input.Length > index ? input[index++] : null;
                    var right = input.Length > index ? input[index++] : null;

                    var node = queue.Dequeue();
                    if (left != null)
                    {
                        node.left = new TreeNode(left.Value);
                        queue.Enqueue(node.left);
                    }

                    if (right != null)
                    {
                        node.right = new TreeNode(right.Value);
                        queue.Enqueue(node.right);
                    }
                }
            }

            var actual = solution.LargestValues(treeRoot);
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