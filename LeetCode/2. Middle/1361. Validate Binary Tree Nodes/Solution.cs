using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1361._Validate_Binary_Tree_Nodes
{
    public class Solution
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            var hash = new HashSet<int>();

            var queue = new Queue<int>();

            var vertex = FindVertex(leftChild, rightChild);
            if (vertex == -1)
                return true;
            if (vertex == -2)
                return false;

            queue.Enqueue(vertex);
            hash.Add(vertex);

            while (queue.Count > 0)
            {
                var value = queue.Dequeue();

                var left = leftChild[value];
                var right = rightChild[value];

                if (hash.Contains(left) || hash.Contains(right))
                    return false;

                if (left != -1)
                {
                    hash.Add(left);
                    queue.Enqueue(left);
                }

                if (right != -1)
                {
                    hash.Add(right);
                    queue.Enqueue(right);
                }
            }

            if (hash.Count != n)
                return false;

            for (var i = 0; i < n; i++)
            {
                var left = leftChild[i];
                var right = rightChild[i];

                if (left != -1)
                {
                    if (!hash.Contains(left))
                        return false;
                    hash.Remove(left);
                }

                if (right != -1)
                {
                    if (!hash.Contains(right))
                        return false;
                    hash.Remove(right);
                }
            }

            return true;
        }

        private int FindVertex(int[] leftChild, int[] rightChild)
        {
            try
            {
                var leftDict = leftChild.Select((x, i) => (x, i)).Where(x => x.x != -1)
                    .ToDictionary(x => x.x, x => x.i);
                var rightDict = rightChild.Select((x, i) => (x, i)).Where(x => x.x != -1)
                    .ToDictionary(x => x.x, x => x.i);

                if (leftDict.Count == 0 && rightDict.Count == 0)
                    return -1;

                var vertex = leftDict.Count == 0
                    ? rightDict.First().Value
                    : leftDict.First().Value;

                for (var i = 0; i < 10_000; i++)
                {
                    if (leftDict.ContainsKey(vertex))
                    {
                        vertex = leftDict[vertex];
                        continue;
                    }

                    if (rightDict.ContainsKey(vertex))
                    {
                        vertex = rightDict[vertex];
                        continue;
                    }

                    break;
                }

                return vertex;
            }
            catch
            {
                return -2;
            }
        }
    }
}