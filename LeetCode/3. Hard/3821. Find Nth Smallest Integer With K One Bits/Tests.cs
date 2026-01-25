using NUnit.Framework;

namespace LeetCode._3._Hard._3821._Find_Nth_Smallest_Integer_With_K_One_Bits;

[TestFixture(TestName = "3821. Find Nth Smallest Integer With K One Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(9, 2, 20)]
    [TestCase(4, 2, 9)]
    [TestCase(3, 1, 4)]
    public void Test(long input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.NthSmallest(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
