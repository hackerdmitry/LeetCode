using System;
using NUnit.Framework;

namespace LeetCode._1._Easy._703._Kth_Largest_Element_in_a_Stream;

[TestFixture(TestName = "703. Kth Largest Element in a Stream")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, new[]{4, 5, 8, 2}, new[]{3,5,10,9,4}, new[]{4, 5, 5, 8, 8})]
    [TestCase(2, new[]{0}, new[]{-1,1,-2,-4,3}, new[]{-1,0,0,0,1})]
    [TestCase(3, new[]{5,-1}, new[]{2,1,-1,3,4}, new[]{-1,1,1,2,3})]
    public void Test(int k, int[] startNums, int[] toAddNums, int[] expectedNums)
    {
        var kthLargest = new KthLargest(k, startNums);

        for (var i = 0; i < toAddNums.Length; i++)
        {
            var expectedNum = expectedNums[i];
            var actualNum = kthLargest.Add(toAddNums[i]);
            Console.WriteLine($"exp={expectedNum}, act={actualNum}");
            Assert.AreEqual(expectedNum, actualNum);
        }
    }
}
